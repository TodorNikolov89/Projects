namespace CarDealer.Web.Models.Cars
{
    using System.Collections.Generic;
    using Services.Models.Parts;

    public class CarViewModel
    {
        public int Id { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public long TravelledDistance { get; set; }

    }
}
