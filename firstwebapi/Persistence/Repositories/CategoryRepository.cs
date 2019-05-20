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
    public class CategoryRepository: BaseRepository, ICategoryRepository
    {
        public CategoryRepository(ApplicationDatabaseContext context): base(context)
        {

        }

        public Task AddAsync(Category category)
        {
            return _context.Categories.AddAsync(category);
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}
