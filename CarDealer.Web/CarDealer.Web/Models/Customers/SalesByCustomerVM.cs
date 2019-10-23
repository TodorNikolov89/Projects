namespace CarDealer.Web.Models.Customers
{
    public class SalesByCustomerVM
    {
        public string Name { get; set; }

        public int BoughtCarsCount { get; set; }

        public decimal TotalSpentMoney { get; set; }
    }
}
