﻿namespace CarDealer.Services
{
    using Models.Parts;
    using System.Collections.Generic;

    public interface IPartService
    {
        IEnumerable<PartListingModel> All(int page = 1, int pageSize = 10);

        void Create(string name, decimal price, int quantity, int supplierId);

        int Total();
    }
}
