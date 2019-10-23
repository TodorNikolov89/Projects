using System.Collections.Generic;
using System.Linq;
using CarDealer.Services.Models.Cars;
using CarDealer.Services.Models.Customers;
using CarDealer.Services.Models.Sales;
using CarDealer.Web.Data;

namespace CarDealer.Services.Implementations
{
    public class SaleService : ISaleService
    {
        //TODO BASE SERVICE AND BASE CONTROLLER

        private readonly CarDealerDbContext db;

        public SaleService(CarDealerDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<SalesModel> GetAll()
        {
            var allSales = this.db
                .Sales
                .Select(s => new SalesModel
                {
                    Car = new CarModel
                    {
                        Make = s.Car.Make,
                        Model = s.Car.Model,
                        TravelledDistance = s.Car.TravelLedDistance
                    },
                    Customer = new CustomerModel
                    {
                        Name = s.Customer.Name,
                        BirthDay = s.Customer.BirthDay,
                        IsYoungDriver = s.Customer.IsYoungDriver
                    },

                    Price = s.Car.Parts.Sum(p => p.Part.Price),
                    PriceWithDiscount = (double)s.Car.Parts.Sum(p => p.Part.Price) - ((double)s.Car.Parts.Sum(p => p.Part.Price) * s.Discount),
                    DiscountPercent = s.Discount * 100
                })
                .ToList();

            return allSales;
        }


        //TODO check for invalid ID
        public SalesModelById GetSaleById(int Id)
        {
            SalesModelById saleInfoById = this.db
                .Sales
                .Where(s => s.Id == Id)
                .Select(x => new SalesModelById
                {
                    Id = x.Id,
                    Car = new CarModel
                    {
                        Make = x.Car.Make,
                        Model = x.Car.Model,
                        // TravelledDistance = x.Car.TravelLedDistance
                    },
                    Customer = new CustomerModel
                    {
                        Name = x.Customer.Name,
                        //  BirthDay = x.Customer.BirthDay,
                        // IsYoungDriver = x.Customer.IsYoungDriver
                    }
                })
                .FirstOrDefault();

            return saleInfoById;
        }

        public IEnumerable<SalesModel> GetDiscountedSales()
        {
            var allDiscountedSales = this.GetAll().Where(s => s.DiscountPercent > 0.00);

            return allDiscountedSales;
        }

        public IEnumerable<SalesModel> GetDiscountedSalesByAnyPercent(int perc)
        {
            var allDicountedSalesPerAnyPercent = this.GetAll().Where(s => s.DiscountPercent == perc).ToList();

            return allDicountedSalesPerAnyPercent;
        }
    }
}
