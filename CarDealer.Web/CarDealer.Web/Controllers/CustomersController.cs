namespace CarDealer.Web.Controllers
{
    using AutoMapper;
    using CarDealer.Services;
    using CarDealer.Services.Models;
    using CarDealer.Services.Models.Customers;
    using CarDealer.Web.Models.Customers;
    using Microsoft.AspNetCore.Mvc;

    [Route("customers")]
    public class CustomersController : Controller
    {
        private readonly ICustomerService customers;

        private readonly IMapper mapper;
        public CustomersController(ICustomerService customers, IMapper mapper)
        {
            this.customers = customers;
            this.mapper = mapper;
        }

        [Route(nameof(Create))]
        public IActionResult Create() => View();

        [HttpPost]
        [Route(nameof(Create))]
        public IActionResult Create(CustomerFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return this.View(model);
            }

            this.customers.Create
                (
                model.Name,
                model.BirthDay,
                model.IsYoungDriver
                );

            return RedirectToAction(nameof(All), new { order = OrderDirection.Ascending });

        }

        [Route(nameof(Edit) + "/{id}")]
        public IActionResult Edit(int id)
        {
            var customer = this.customers.ById(id);

            if (customer == null)
            {
                return NotFound();
            }

            return View(new CustomerFormModel
            {
                Name = customer.Name,
                BirthDay = customer.BirthDay,
                IsYoungDriver = customer.IsYoungDriver
            });
        }

        [HttpPost]
        [Route(nameof(Edit) + "/{id}")]
        public IActionResult Edit(int id, CustomerFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return this.View(model);
            }

            var customerExists = this.customers.Exists(id);


            if (!customerExists)
            {
                return NotFound();
            }

            this.customers.Edit
             (
                id,
             model.Name,
             model.BirthDay,
             model.IsYoungDriver
             );

            return RedirectToAction(nameof(All), new { order = OrderDirection.Ascending });
        }

        [Route("all/{order}")]
        public IActionResult All(string order)
        {
            var orderDirection = order.ToLower() == "descending"
                ? OrderDirection.Descending
                : OrderDirection.Ascending;

            var customers = this.customers.OrderedCustomers(orderDirection);

            return View(new AllCustomersModel
            {
                Customers = customers,
                OrderDirection = orderDirection
            });
        }

        [Route("{customerId}")]
        public IActionResult SalesByCustomer(int customerId)
        {
            CustomerSales customerInfo = this.customers.TotalSalesByCustomerId(customerId);

            SalesByCustomerVM customerInfoVm = mapper.Map<SalesByCustomerVM>(customerInfo);

            return View(customerInfoVm);
        }
    }
}
