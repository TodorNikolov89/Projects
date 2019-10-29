﻿using CarDealer.Services.Models.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealer.Web.Models.Cars
{
    public class CarsPageListingModel
    {
        public IEnumerable<CarModel> Cars { get; set; }

        public int CurrentPage { get; set; }

        public int TotalPages { get; set; }


        public int PreviousPage => this.CurrentPage == 1
            ? 1
            : this.CurrentPage - 1;

        public int NextPage => this.CurrentPage == this.TotalPages
            ? this.TotalPages
            : this.CurrentPage + 1;
    }
}
