using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlinesShop.Application.Interfaces;
using OnlinesShop.Infrastructure.Dto;

namespace OnlinesShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var result = await _productService.GetProduct(id);
            if (result == null)
                return NotFound("Product not found");
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _productService.GetAllProducts();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductDto model)
        {
            var result = await _productService.AddProduct(model);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var deleteResult = await _productService.DeleteProduct(id);
            if (deleteResult == false)
            {
                return NotFound("Product Not Found");
            }
            return Ok("Product Deleted Successfully");

        }
    }
}
