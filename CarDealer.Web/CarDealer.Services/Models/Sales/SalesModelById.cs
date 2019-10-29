using CarDealer.Data.Models;
using CarDealer.Services.Models.Cars;
using CarDealer.Services.Models.Customers;

namespace CarDealer.Services.Models.Sales
{
    public class SalesModelById
    {
        public int Id { get; set; }

        public CarModel Car { get; set; }

        public CustomerModel Customer { get; set; }
    }
}
