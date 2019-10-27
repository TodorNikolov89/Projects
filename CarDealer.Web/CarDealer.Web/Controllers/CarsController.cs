namespace CarDealer.Web.Controllers
{
    using AutoMapper;
    using CarDealer.Services;
    using CarDealer.Web.Models.Cars;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;

    [Route("cars")]
    public class CarsController : Controller
    {
        private readonly ICarService cars;
        private readonly IMapper mapper;
        private const int PageSize = 25;

        public CarsController(IMapper mapper, ICarService cars)
        {
            this.mapper = mapper;
            this.cars = cars;
        }


        [Route("{make}")]
        public IActionResult ByMake(string make)
        {
            var cars = this.cars.ByMake(make);

            return this.View(new CarsByMakeModel
            {
                Make = make,
                Cars = cars
            });
        }

        [Route(nameof(Delete) + "/{id}")]
        public IActionResult Delete(int id)
               => View(id);



        [Route(nameof(Destroy) + "/{id}")]
        public IActionResult Destroy(int id)
        {
            this.cars.Delete(id);

            return RedirectToAction(nameof(All));
        }

        [Route(nameof(Create))]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        [Route(nameof(Create))]
        public IActionResult Create(CarFormModel carModel)
        {
            if (!ModelState.IsValid)
            {
                return View(carModel);
            }

            this.cars.Create(
                carModel.Make,
                carModel.Model,
                carModel.TravelledDistance
                );

            return RedirectToAction(nameof(All));
        }


        [Route("parts", Order = 1)]
        public IActionResult Parts()
        {
            return View(this.cars.Parts());
        }

        [Route(nameof(Edit) + "/{id}")]
        public IActionResult Edit(int id)
        {
            var car = this.cars.ById(id);

            if (car == null)
            {
                return NotFound();
            }

            CarFormModel carToEdit = mapper.Map<CarFormModel>(car);

            return View(carToEdit);
        }

        [HttpPost]
        [Route(nameof(Edit) + "/{id}")]
        public IActionResult Edit(int id, CarFormModel carModel)
        {
            if (!ModelState.IsValid)
            {
                carModel.IsEdit = true;
                return View(carModel);
            }

            this.cars.Edit(
                id,
                carModel.Make,
                carModel.Model,
                carModel.TravelledDistance
                );

            return RedirectToAction(nameof(All));
        }

        [Route(nameof(All))]
        public IActionResult All(int page = 1)
        => View(new CarsPageListingModel
        {
            Cars = this.cars.GetAllCars(page, PageSize),
            CurrentPage = page,
            TotalPages = (int)Math.Ceiling(this.cars.Total() / (double)PageSize)
        });
    }
}
