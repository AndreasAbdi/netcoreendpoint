using firstwebapi.Domain.Models;
using firstwebapi.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstwebapi.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> ListAsync();

        Task<Product> FindProductByIdAsync();

        Task DeleteProductAsync(Product product);

        Task UpdateProductAsync(Product product);

        Task AddProductAsync(Product product);
    }
}
