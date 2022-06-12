using EFCoreProject.Application.Contracts.ProductCategory;
using EFCoreProject.Domain.ProductCategoryAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreProject.Infrastructure.EFCore.Repository
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private readonly EFContext _context;

        public ProductCategoryRepository(EFContext context)
        {
            _context = context;
        }
        public void Create(ProductCategory productCategory)
        {
            _context.ProductCategories.Add(productCategory);
            SaveChanges();
        }

        public bool Exists(string name)
        {
            return _context.ProductCategories.Any(c => c.Name == name);
        }

        public ProductCategory Get(int id)
        {
            return _context.ProductCategories.FirstOrDefault(q => q.Id == id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public List<ProductCategoryViewModel> Search(string name)
        {
            var query = _context.ProductCategories.Select(q => new ProductCategoryViewModel
            {
                Id = q.Id,
                Name = q.Name,
                CreationDate = q.CreationDate.ToString()
            });

            if (!string.IsNullOrWhiteSpace(name))
            {
                query = query.Where(q => q.Name.Contains(name));
            }

            return query.OrderByDescending(q => q.Id).ToList();
        }
    }
}
