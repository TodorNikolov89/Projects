using System;

namespace CarDealer.Web.Models.Customers
{
    public class CustomerViewModel
    {
        public string Name { get; set; }

        public DateTime BirthDay { get; set; }

        public bool IsYoungDriver { get; set; }
    }
}
