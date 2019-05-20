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
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUnitOfWork _unitOfWork;
        
        public CategoryService(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
        {
            this._categoryRepository = categoryRepository;
            this._unitOfWork = unitOfWork;
        }

        public Task<IEnumerable<Category>> ListAsync()
        {
            return _categoryRepository.ListAsync();
        }

        public async Task<SaveCategoryResponse> SaveAsync(Category category)
        {
            try
            {
                await _categoryRepository.AddAsync(category);
                await _unitOfWork.CompleteAsync();

                return new SaveCategoryResponse(category);
            }
            catch(Exception ex)
            {
                return new SaveCategoryResponse($"An error occurred when saving the category: ${ex.Message}");
            }
        }

        public async Task<UpdateCategoryResponse> UpdateAsync(int id, Category category)
        {

            var existingCategory = await _categoryRepository.FindByIdAsync(id);

            if (existingCategory == null)
                return new UpdateCategoryResponse("Category not found.");
            existingCategory.Name = category.Name;

            try
            {
                _categoryRepository.Update(existingCategory);
                await _unitOfWork.CompleteAsync();

                return new UpdateCategoryResponse(category);
            }
            catch(Exception exception)
            {
                return new UpdateCategoryResponse($"An error occurred when updating the category: ${exception.Message}");
            }
        }
    }
}
