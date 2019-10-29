namespace CarDealer.Services.Implementations
{
    using System.Collections.Generic;
    using System.Linq;
    using Models.Suppliers;
    using CarDealer.Web.Data;
    public class SupplierService : ISupplierService
    {
        private readonly CarDealerDbContext db;

        public SupplierService(CarDealerDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<SupplierModel> All()
        => this.db
            .Suppliers
            .OrderBy(s => s.Name)
            .Select(s => new SupplierModel
            {
                Id = s.Id,
                Name = s.Name
            })
            .ToList();

        public IEnumerable<SupplierListingModel> AllListings(bool isImporter)
        => this.db
            .Suppliers
            .Where(s => s.IsImporter == isImporter)
            .Select(s => new SupplierListingModel
            {
                Id = s.Id,
                Name = s.Name,
                TotalParts = s.Parts.Count
            })
            .ToList();
    }
}
