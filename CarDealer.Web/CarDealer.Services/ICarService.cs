namespace CarDealer.Services
{
    using CarDealer.Services.Models.Cars;
    using System.Collections.Generic;
    public interface ICarService
    {
        IEnumerable<CarModel> ByMake(string make);

        IEnumerable<CarWithPartsModel> Parts();

        void Create(string make, string model, long travelledDistance);

        void Delete(int id);

        CarModel ById(int id);

        IEnumerable<CarModel> GetAllCars(int page = 1, int pageSize = 10);

        void Edit(int id, string make, string model, long travelledDistance);

         int Total();
    }
}
