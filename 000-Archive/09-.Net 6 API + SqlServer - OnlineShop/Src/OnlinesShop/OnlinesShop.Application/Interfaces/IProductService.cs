using OnlinesShop.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinesShop.Application.Interfaces
{
    public interface IProductService
    {
        Task<List<ProductDto>> GetAllProducts();
        Task<ProductDto> GetProduct(int productId);
        Task<ProductDto> AddProduct(ProductDto productDto);
        Task<bool> DeleteProduct(int productId);
    }
}
