namespace CarDealer.Services.Implementations
{
    using System.Collections.Generic;
    using CarDealer.Services.Models;
    using CarDealer.Data;
    using CarDealer.Web.Data;
    using System.Linq;
    using System;
    using CarDealer.Services.Models.Customers;
    using CarDealer.Data.Models;

    public class CustomerService : ICustomerService
    {
        private readonly CarDealerDbContext db;

        public CustomerService(CarDealerDbContext db)
        {
            this.db = db;
        }

        public CustomerModel ById(int id)
        => this.db.Customers.Where(c => c.Id == id)
            .Select(c => new CustomerModel
            {
                Id = c.Id,
                Name = c.Name,
                BirthDay = c.BirthDay,
                IsYoungDriver = c.IsYoungDriver
            })
            .FirstOrDefault();

        public void Create(string name, DateTime birthDay, bool isYoungDriver)
        {
            var customer = new Customer
            {

                Name = name,
                BirthDay = birthDay,
                IsYoungDriver = isYoungDriver
            };

            this.db.Add(customer);
            db.SaveChanges();
        }


        public void Edit(int id, string name, DateTime birthDay, bool isYoungDriver)
        {
            var existingCustomer = this.db.Customers.Find(id);

            if (existingCustomer == null)
            {
                return;
            }

            existingCustomer.Name = name;
            existingCustomer.BirthDay = birthDay;
            existingCustomer.IsYoungDriver = isYoungDriver;

            this.db.SaveChanges();
        }

        public bool Exists(int id)
        => this.db.Customers.Any(c => c.Id == id);

        public IEnumerable<CustomerModel> OrderedCustomers(OrderDirection order)
        {
            var customersQuery = this.db.Customers.AsQueryable();

            switch (order)
            {
                case OrderDirection.Ascending:
                    customersQuery = customersQuery
                        .OrderBy(c => c.BirthDay)
                        .ThenBy(c => c.Name);
                    break;
                case OrderDirection.Descending:
                    customersQuery = customersQuery
                        .OrderByDescending(c => c.BirthDay)
                        .ThenBy(c => c.Name);
                    break;
                default:
                    throw new InvalidOperationException($"Invalid order direction: {order}.");
            }

            return customersQuery
                .Select(c => new CustomerModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    BirthDay = c.BirthDay,
                    IsYoungDriver = c.IsYoungDriver
                })
                .ToList();
        }

        public CustomerSales TotalSalesByCustomerId(int customerId)
        {
            var customerInfo = this.db
                .Customers
                .Where(c => c.Id == customerId)
                .Select(c => new CustomerSales
                {
                    Name = c.Name,
                    BoughtCarsCount = c.Sales.Count,
                    TotalSpentMoney = c.Sales.Sum(s => s.Car.Parts.Sum(p => p.Part.Price))
                })
               .FirstOrDefault();

            return customerInfo;
        }
    }
}
