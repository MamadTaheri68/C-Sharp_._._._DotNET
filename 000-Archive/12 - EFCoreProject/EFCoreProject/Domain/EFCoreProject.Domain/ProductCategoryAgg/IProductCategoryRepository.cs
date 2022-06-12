using EFCoreProject.Application.Contracts.ProductCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreProject.Domain.ProductCategoryAgg
{
    public interface IProductCategoryRepository
    {
        void SaveChanges();
        bool Exists(string name);
        void Create(ProductCategory productCategory);
        ProductCategory Get(int id);
        List<ProductCategoryViewModel> Search(string name);
    }
}
