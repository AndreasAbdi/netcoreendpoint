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

        public async Task<Category> FindByIdAsync(int id)
        {
            return await _context.Categories.FindAsync(id);
        }

        public void Update(Category category)
        {
            _context.Categories.Update(category);
        }

        public void deleteAsync(Category category)
        {
            _context.Categories.Remove(category);
        }
    }
}
