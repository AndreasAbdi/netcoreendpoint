using firstwebapi.Domain.Models;
using firstwebapi.Domain.Repositories;
using firstwebapi.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstwebapi.Persistence.Repositories
{
    class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(ApplicationDatabaseContext context) : base(context) { }

        public async Task AddProductAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteProductAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> FindProductByIdAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> ListAsync()
        {
            return await _context.Products
                .Include(property => property.Category)
                .ToListAsync();
        }

        public async Task UpdateProductAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
