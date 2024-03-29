﻿namespace CarDealer.Web.Models.Suppliers
{
    using System.Collections.Generic;
    using Services.Models.Suppliers;

    public class SuppliersModel
    {
        public string Type { get; set; }

        public IEnumerable<SupplierListingModel> Suppliers { get; set; }
    }
}
