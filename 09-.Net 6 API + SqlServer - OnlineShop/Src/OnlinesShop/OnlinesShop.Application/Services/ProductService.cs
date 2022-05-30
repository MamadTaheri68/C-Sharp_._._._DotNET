using Microsoft.EntityFrameworkCore;
using OnlinesShop.Application.Interfaces;
using OnlinesShop.Core.Entities;
using OnlinesShop.Infrastructure.Contexts;
using OnlinesShop.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace OnlinesShop.Application.Services
{
    public class ProductService : IProductService
    {
        // No Repository -> So we will inject OnloneShopDbContext itself

        private readonly OnlineShopDbContext _onlineShopDbContext;
        private readonly IMapper _mapper;

        public ProductService(OnlineShopDbContext onlineShopDbContext, IMapper mapper)
        {
            _onlineShopDbContext = onlineShopDbContext;
            _mapper = mapper;
        }

        public async Task<ProductDto> AddProduct(ProductDto productDto)
        {
            // We should change from ProductDto to Product Entity
            // easy way => use Automapper

            //var product = new Product
            //{
            //    ProductName = productDto.ProductName,
            //    Price = productDto.Price,
            //};
            
            var product = _mapper.Map<Product>(productDto);

            await _onlineShopDbContext.AddAsync(product);
            await _onlineShopDbContext.SaveChangesAsync();
           
            productDto.Id = productDto.Id;
            return productDto;
        }

        public async Task<bool> DeleteProduct(int productId)
        {
            var productToDelete = await _onlineShopDbContext.Products.FindAsync(productId);

            if (productToDelete == null)
                return false;

            _onlineShopDbContext.Remove(productToDelete);
            return true;
        }

        public async Task<List<ProductDto>> GetAllProducts()
        {
            //var result = await _onlineShopDbContext.Products.Select(q => new ProductDto
            //{
            //    Id = q.Id,
            //    ProductName = q.ProductName,
            //    Price = q.Price,
            //    PriceWithComma = q.Price.ToString("###.###"),
            //}).ToListAsync();

            var products = await _onlineShopDbContext.Products.ToListAsync();

            var result = _mapper.Map<List<ProductDto>>(products);

            return result;
        }

        public async Task<ProductDto> GetProduct(int productId)
        {
            //var product = await _onlineShopDbContext.Products.FindAsync((long)productId);

            //if (product == null)
            //    return null;

            //var model = new ProductDto
            //{
            //    Id = product.Id,
            //    ProductName = product.ProductName,
            //    Price = product.Price,
            //    PriceWithComma = product.Price.ToString("###.###"),
            //};

            var product = await _onlineShopDbContext.Products.FindAsync(productId);
            var model = _mapper.Map<ProductDto>(product);

            return model;
        }
    }
}   
