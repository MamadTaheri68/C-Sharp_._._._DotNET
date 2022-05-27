using EFCoreProject.Application.Contracts.Product;
using EFCoreProject.Domain.ProductAgg;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreProject.Infrastructure.EFCore.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly EFContext _eFContext;

        public ProductRepository(EFContext eFContext)
        {
            _eFContext = eFContext;
        }
        public void Create(Product product)
        {
            _eFContext.Products.Add(product);
        }

        public bool Exists(string name, int categoryId)
        {
            return _eFContext.Products.Any(q => q.Name == name &&  q.CategoryId == categoryId);
        }

        public Product Get(int id)
        {
            return _eFContext.Products.FirstOrDefault(q => q.Id == id);
        }

        public EditProduct GetDetails(int id)
        {
            var result = _eFContext.Products.Select(q => new EditProduct 
            { 
                Id = q.Id,
                Name = q.Name,
                UnitPrice = q.UnitPrice,
                CategoryId = q.CategoryId,
            }).FirstOrDefault(q => q.Id == id);

            return result;
        }

        public void SaveChanges()
        {
            _eFContext.SaveChanges();
        }

        public List<ProductViewModel> Search(ProductSearchModel searchModel)
        {
            var query = _eFContext.Products
                .Include(q=>q.Category)   // Join Table
                .Select(q => new ProductViewModel
                {
                    Id = q.Id,
                    Name = q.Name,
                    UnitPrice = q.UnitPrice,
                    IsRemoved = q.IsRemoved,
                    CreationDate = q.CreationDate.ToString(),
                    Category = q.Category.Name
                });
            
            if(searchModel.IsRemoved == true)
                query = query.Where(q => q.IsRemoved == true);

            if(!string.IsNullOrWhiteSpace(searchModel.Name))
                query = query.Where(q => q.Name.Contains(searchModel.Name));

            return query.OrderByDescending(q => q.Id).AsNoTracking().ToList();

        }
    }
}
