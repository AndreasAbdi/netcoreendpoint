using firstwebapi.Domain.Models;
using firstwebapi.Domain.Repositories;
using firstwebapi.Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstwebapi.Domain.Services.Impl
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRespository;
        
        public CategoryService(ICategoryRepository categoryRepository)
        {
            this._categoryRespository = categoryRepository;
        }

        public Task<IEnumerable<Category>> ListAsync()
        {
            return _categoryRespository.ListAsync();
        }
    }
}
