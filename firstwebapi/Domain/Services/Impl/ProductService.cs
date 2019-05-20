using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using firstwebapi.Domain.Models;
using firstwebapi.Domain.Repositories;
using firstwebapi.Persistence.Repositories;

namespace firstwebapi.Domain.Services.Impl
{
    public class ProductService : IProductService
    {
        IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<IEnumerable<Product>> ListAsync()
        {
            return await _productRepository.ListAsync();
        }
    }
}
