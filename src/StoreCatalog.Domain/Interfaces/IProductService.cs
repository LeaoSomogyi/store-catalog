﻿using GeekBurger.Products.Contract;
using StoreCatalog.Contract.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StoreCatalog.Domain.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductToGet>> GetProductsAsync();
    }
}