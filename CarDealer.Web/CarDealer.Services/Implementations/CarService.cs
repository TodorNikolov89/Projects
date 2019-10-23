namespace CarDealer.Services.Implementations
{
    using System;
    using Models.Cars;
    using Models.Parts;
    using System.Collections.Generic;
    using System.Linq;
    using CarDealer.Web.Data;
    using CarDealer.Services.Models;

    public class CarService : ICarService
    {
        private readonly CarDealerDbContext db;

        public CarService(CarDealerDbContext db)
        {
            this.db = db;
        }
      

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

        public ICollection<CarModel> GetAllCars()
        {
            var allCars = this.db
                .Cars
                .Select(c => new CarModel
                {
                    Make = c.Make,
                    Model = c.Model,
                    TravelledDistance = c.TravelLedDistance /1000
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
