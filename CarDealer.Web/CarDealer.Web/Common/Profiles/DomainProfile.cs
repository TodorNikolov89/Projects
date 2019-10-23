namespace CarDealer.Web.Common.Profiles
{
    using AutoMapper;
    using CarDealer.Services.Models.Cars;
    using CarDealer.Services.Models.Customers;
    using CarDealer.Services.Models.Sales;
    using CarDealer.Web.Models.Cars;
    using CarDealer.Web.Models.Customers;
    using CarDealer.Web.Models.Sales;

    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<CustomerSales, SalesByCustomerVM>().ReverseMap();

            CreateMap<SalesModel, SalesViewModel>().ReverseMap();

            CreateMap<CarModel, CarViewModel>().ReverseMap();

            CreateMap<CustomerModel, CustomerViewModel>().ReverseMap();

            CreateMap<SalesModelById, SaleIdInfoViewModel>().ReverseMap();
        }
    }
}
