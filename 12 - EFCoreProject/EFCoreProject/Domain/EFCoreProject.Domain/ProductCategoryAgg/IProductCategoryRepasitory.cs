using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreProject.Domain.ProductCategoryAgg
{
    internal interface IProductCategoryRepasitory
    {
        ProductCategory Get(int id);
        void Create(ProductCategory productCategory);
    }
}
