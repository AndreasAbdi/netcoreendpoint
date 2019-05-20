using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using firstwebapi.Domain.Services;
using firstwebapi.Extensions;
using firstwebapi.Resources;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace firstwebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductResource>> ListAsync()
        {
            var products = await _productService.ListAsync();
            var resources = products.Select(product =>
            {
                var productResource = new ProductResource();
                productResource.UnitOfMeasurement = product.UnitOfMeasurement.ToDescriptionString();
                productResource.Name = product.Name;
                productResource.Id = product.Id;
                productResource.QuantityInPackage = product.QuantityInPackage;

                var categoryResource = new CategoryResource(product.Category.Id, product.Category.Name);
                productResource.Category = categoryResource;

                return productResource;
            });
            return resources;
        }
    }
}