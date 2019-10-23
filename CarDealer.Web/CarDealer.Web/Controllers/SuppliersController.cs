namespace CarDealer.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using CarDealer.Services;
    using CarDealer.Services.Models;
    using CarDealer.Web.Models.Suppliers;
    using Microsoft.AspNetCore.Mvc;
    public class SuppliersController : Controller
    {

        private readonly ISupplierService suppliers;

        private static readonly string SuppliersView = "Suppliers";

        public SuppliersController(ISupplierService suppliers)
        {
            this.suppliers = suppliers;
        }


        public IActionResult Local()
        {
            return this.View(SuppliersView, this.GetSupplierModel(false));
        }


        public IActionResult Importers()
        {
            return this.View(SuppliersView, this.GetSupplierModel(true));
        }


        private SuppliersModel GetSupplierModel(bool importers)
        {
            var type = importers ? "Importer" : "Local";

            var suppliers = this.suppliers.AllListings(importers);

            return new SuppliersModel
            {
                Type = type,
                Suppliers = suppliers
            };
        }
    }
}