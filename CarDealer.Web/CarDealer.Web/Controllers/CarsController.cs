
namespace CarDealer.Web.Controllers
{
    using AutoMapper;
    using CarDealer.Services;
    using CarDealer.Web.Models.Cars;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;

    public class CarsController : Controller
    {
        private readonly ICarService cars;
        private readonly IMapper mapper;
        public CarsController(IMapper mapper, ICarService cars)
        {
            this.mapper = mapper;
            this.cars = cars;
        }


        [Route("cars/{make}")]
        public IActionResult ByMake(string make)
        {
            var cars = this.cars.ByMake(make);

            return this.View(new CarsByMakeModel
            {
                Make = make,
                Cars = cars
            });
        }

        public IActionResult Parts()
        {
            return View(this.cars.Parts());
        }


        public IActionResult All()
        {
            var allCars = cars.GetAllCars();

            IEnumerable<CarViewModel> carsInfo = mapper.Map<IEnumerable<CarViewModel>>(allCars);

            return View(carsInfo);
        }
    }
}
