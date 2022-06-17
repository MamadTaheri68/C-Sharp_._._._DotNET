using OnlineShop_Deram.Core.Entities;
using OnlineShop_Deram.Infrastructure.Dto;

namespace OnlineShop_Deram.Application.Interfaces
{
    public interface IProductService
    {
        Task<List<ProductDto>> GetAll();
        Task<ProductDto> Get(int id);
        Task<ProductDto> Add(ProductDto model);
    }
}
