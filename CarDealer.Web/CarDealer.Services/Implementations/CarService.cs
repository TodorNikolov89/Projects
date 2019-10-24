namespace CarDealer.Services.Implementations
{
    using System;
    using Models.Cars;
    using Models.Parts;
    using System.Collections.Generic;
    using System.Linq;
    using CarDealer.Web.Data;
    using CarDealer.Services.Models;
    using Data.Models;

    public class CarService : ICarService
    {
        private readonly CarDealerDbContext db;

        public CarService(CarDealerDbContext db)
        {
            this.db = db;
        }

        public CarModel ById(int id)
         => this.db
            .Cars
            .Where(c => c.Id == id)
            .Select(p => new CarModel
            {
                Id = p.Id,
                Make = p.Make,
                Model = p.Model,
                TravelledDistance = p.TravelLedDistance
            })
            .FirstOrDefault();

        public IEnumerable<CarModel> ByMake(string make)
        {
            return this.db
                .Cars
                .Where(c => c.Make.ToLower() == make.ToLower())
                .OrderBy(c => c.Model)
                .ThenBy(c => c.TravelLedDistance)
                .Select(c => new CarModel
                {
                    Make = c.Make,
                    Model = c.Model,
                    TravelledDistance = c.TravelLedDistance
                })
                .ToList();
        }

        public void Create(string make, string model, long travelledDistance)
        {
            var car = new Car
            {
                Make = make,
                Model = model,
                TravelLedDistance = travelledDistance
            };

            this.db.Cars.Add(car);
            this.db.SaveChanges();
        }

        public void Delete(int id)
        {
            var car = this.db
                .Cars.Find(id);

            if (car == null)
            {
                return;
            }

            this.db.Cars.Remove(car);
            this.db.SaveChanges();
        }

        public void Edit(int id, string make, string model, long travelledDistance)
        {
            var car = this.db
                .Cars
                .Find(id);

            if (car == null)
            {
                return;
            }

            car.Model = model;
            car.Make = make;
            car.TravelLedDistance = travelledDistance;

            this.db.SaveChanges();
        }

        public IEnumerable<CarModel> GetAllCars()
        {
            var allCars = this.db
                .Cars
                .OrderByDescending(c => c.Id)
                .Select(c => new CarModel
                {
                    Make = c.Make,
                    Model = c.Model,
                    TravelledDistance = c.TravelLedDistance,
                    Id = c.Id
                })
                .ToList();

            return allCars;
        }

        public IEnumerable<CarWithPartsModel> Parts()
        => this.db.Cars.Select(c => new CarWithPartsModel
        {
            Make = c.Make,
            Model = c.Model,
            TravelledDistance = c.TravelLedDistance,
            Parts = c.Parts.Select(p => new PartModel
            {
                Name = p.Part.Name,
                Price = p.Part.Price
            })
        })
            .ToList();
    }
}
