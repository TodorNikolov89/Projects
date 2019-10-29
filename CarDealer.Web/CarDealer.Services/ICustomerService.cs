namespace CarDealer.Services
{
    using Models;
    using Models.Customers;
    using System;
    using System.Collections.Generic;

    public interface ICustomerService
    {
        IEnumerable<CustomerModel> OrderedCustomers(OrderDirection order);

        CustomerSales TotalSalesByCustomerId(int customerId);

        void Create(string name, DateTime birthDay, bool isYoungDriver);

        CustomerModel ById(int id);
        void Edit(int id, string name, DateTime birthDay, bool isYoungDriver);
        bool Exists(int id);
    }
}
