using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using firstwebapi.Domain.Models;
using firstwebapi.Domain.Service;
using firstwebapi.Extensions;
using firstwebapi.Resources;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace firstwebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IEnumerable<CategoryResource>> GetAllAsync()
        {
            var categories = await _categoryService.ListAsync();

            var resources = categories
                .Select(category => new CategoryResource(category.Id, category.Name));
            return resources;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveCategoryResource resource)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState.GetErrorMessages());
            }

            var resourceToSave = new Category();
            resourceToSave.Name = resource.Name;

            var result = await _categoryService.SaveAsync(resourceToSave);

            if (!result.Success)
                return BadRequest(result.Message);

            var categoryResource = new CategoryResource(result.Category.Id, result.Category.Name);
            return Ok(categoryResource);

        }


        [HttpPut]
        public async Task<IActionResult> PutAsync([FromBody] UpdateCategoryResource resource)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState.GetErrorMessages());
            }

            var resourceToSave = new Category();
            resourceToSave.Name = resource.Name;

            var result = await _categoryService.UpdateAsync(resource.Id, resourceToSave);

            if (!result.Success)
                return BadRequest(result.Message);

            var categoryResource = new CategoryResource(result.Category.Id, result.Category.Name);
            return Ok(categoryResource);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState.GetErrorMessages());
            }

            var result = await _categoryService.DeleteAsync(id);

            if (!result.Success)
                return BadRequest(result.Message);

            var categoryResource = new CategoryResource(result.Category.Id, result.Category.Name);
            return Ok(categoryResource);
        }
    }
}