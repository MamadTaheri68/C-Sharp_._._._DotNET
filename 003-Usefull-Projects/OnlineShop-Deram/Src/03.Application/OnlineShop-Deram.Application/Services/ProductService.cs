using Microsoft.EntityFrameworkCore;
using OnlineShop_Deram.Application.Interfaces;
using OnlineShop_Deram.Core.Entities;
using OnlineShop_Deram.Infrastructure;
using OnlineShop_Deram.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop_Deram.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly OnlineShopDbContext _dbContext;

        public ProductService(OnlineShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<ProductDto> Add(ProductDto model)
        {
            var product = new Product
            {
                ProductName = model.ProductName,
                Price = model.Price,
            };

            await _dbContext.Products.AddAsync(product);
            await _dbContext.SaveChangesAsync();
            model.Id = product.Id;
            
            return model;
        }

        public async Task<ProductDto> Get(int id)
        {
            var product = await _dbContext.Products.FindAsync(id);
            var model = new ProductDto
            {
                Id = product.Id,
                Price = product.Price,
                ProductName = product.ProductName,
                PriceWithComma = product.Price.ToString("###.###"),
            };
            return model;
        }

        public async Task<List<ProductDto>> GetAll()
        {
            var result = await _dbContext.Products.Select(q => new ProductDto
            {
                Id = q.Id,
                Price = q.Price,
                ProductName = q.ProductName,
                PriceWithComma = q.Price.ToString("###.###"),
            }).ToListAsync();
            return result;
        }
    }
}
