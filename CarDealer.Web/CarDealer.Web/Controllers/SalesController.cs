namespace CarDealer.Web.Controllers
{
    using AutoMapper;
    using CarDealer.Services;
    using CarDealer.Services.Models.Sales;
    using CarDealer.Web.Models.Sales;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;

    [Route("sales")]
    public class SalesController : Controller
    {
        private readonly ISaleService sales;

        private readonly IMapper mapper;

        public SalesController(ISaleService sales, IMapper mapper)
        {
            this.sales = sales;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            IEnumerable<SalesModel> allSales = sales.GetAll();

            IEnumerable<SalesViewModel> allSalesView = mapper.Map<List<SalesViewModel>>(allSales);

            return View(allSalesView);
        }

        [Route("{Id}")]
        public IActionResult GetSaleById(int Id)
        {
            SalesModelById saleInfo = sales.GetSaleById(Id);

            SaleIdInfoViewModel saleIdInfo = mapper.Map<SaleIdInfoViewModel>(saleInfo);

            return this.View(saleIdInfo);
        }

        [Route("discounted")]
        public IActionResult GetAllDiscountedSales()
        {
            IEnumerable<SalesModel> allDiscountedSales = sales.GetDiscountedSales();

            IEnumerable<SalesViewModel> allSalesView = mapper.Map<List<SalesViewModel>>(allDiscountedSales);

            return View(allSalesView);
        }

        [Route("discounted/{percent}")]
        public IActionResult DiscountedSalesByPercent(int percent)
        
        {
            IEnumerable<SalesModel> allDiscountedSales = sales.GetDiscountedSalesByAnyPercent(percent);

            IEnumerable<SalesViewModel> allSalesView = mapper.Map<List<SalesViewModel>>(allDiscountedSales);

            return View("GetAllDiscountedSales", allSalesView);
        }
    }
}