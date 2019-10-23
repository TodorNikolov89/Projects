namespace CarDealer.Web.Controllers
{
    using Services;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using CarDealer.Web.Models.Parts;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System.Collections.Generic;

    public class PartsController : Controller
    {
        private readonly IPartService parts;

        private const int PageSize = 25;

        private readonly ISupplierService suppliers;

        public PartsController(IPartService parts, ISupplierService suppliers)
        {
            this.parts = parts;
            this.suppliers = suppliers;
        }

        public IActionResult All(int page = 1)
            => View(new PartPageListingModel
            {
                Parts = this.parts.All(page, PageSize),
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(this.parts.Total() / (double)PageSize)
            });

        public IActionResult Create() => View(new PartFormModel
        {
            Suppliers = GetSupplierListItems()
        });

        [HttpPost]
        public IActionResult Create(PartFormModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Suppliers = GetSupplierListItems();
                return View(model);
            }

            this.parts.Create(
                model.Name,
                model.Price,
                model.Quantity,
                model.SupplierId);

            return RedirectToAction(nameof(All));
        }

        private IEnumerable<SelectListItem> GetSupplierListItems()
        {
            return this.suppliers.All().Select(s => new SelectListItem
            {
                Text = s.Name,
                Value = s.Id.ToString()
            });
        }
    }
}