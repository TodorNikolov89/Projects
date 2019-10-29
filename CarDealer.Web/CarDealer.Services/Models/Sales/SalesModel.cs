namespace CarDealer.Services.Models.Sales
{
    using CarDealer.Services.Models.Cars;
    using CarDealer.Services.Models.Customers;

    public class SalesModel
    {
        public CarModel Car { get; set; }

        public CustomerModel Customer { get; set; }

        public decimal Price { get; set; }

        public double PriceWithDiscount { get; set; }

        public double DiscountPercent { get; set; }
    }
}
