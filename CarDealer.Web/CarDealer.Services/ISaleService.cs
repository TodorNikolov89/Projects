using CarDealer.Services.Models.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarDealer.Services
{
    public interface ISaleService
    {
        IEnumerable<SalesModel> GetAll();

        SalesModelById GetSaleById(int Id);

        IEnumerable<SalesModel> GetDiscountedSales();

        IEnumerable<SalesModel> GetDiscountedSalesByAnyPercent(int percent);

    }
}
