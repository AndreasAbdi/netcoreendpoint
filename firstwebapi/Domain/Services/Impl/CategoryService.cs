using firstwebapi.Domain.Models;
using firstwebapi.Domain.Repositories;
using firstwebapi.Domain.Service;
using firstwebapi.Domain.Services.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstwebapi.Domain.Services.Impl
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRespository;
        private readonly IUnitOfWork _unitOfWork;
        
        public CategoryService(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
        {
            this._categoryRespository = categoryRepository;
            this._unitOfWork = unitOfWork;
        }

        public Task<IEnumerable<Category>> ListAsync()
        {
            return _categoryRespository.ListAsync();
        }

        public async Task<SaveCategoryResponse> SaveAsync(Category category)
        {
            try
            {
                await _categoryRespository.AddAsync(category);
                await _unitOfWork.CompleteAsync();

                return new SaveCategoryResponse(category);
            }
            catch(Exception ex)
            {
                return new SaveCategoryResponse($"An error occurred when saving the category: ${ex.Message}");
            }
        }
    }
}
