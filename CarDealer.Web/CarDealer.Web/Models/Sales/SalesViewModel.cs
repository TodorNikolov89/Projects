using CarDealer.Web.Models.Cars;
using CarDealer.Web.Models.Customers;

namespace CarDealer.Web.Models.Sales
{
    public class SalesViewModel
    {
        public CarViewModel Car { get; set; }

        public CustomerViewModel Customer { get; set; }

        public decimal Price { get; set; }

        public double PriceWithDiscount { get; set; }

        public double DiscountPercent { get; set; }
    }
}
