namespace CarDealer.Web.Models.Sales
{
    using CarDealer.Services.Models.Cars;
    using CarDealer.Services.Models.Customers;

    public class SaleIdInfoViewModel
    {
        public int Id { get; set; }

        public CarModel Car { get; set; }

        public CustomerModel Customer { get; set; }
    }
}
