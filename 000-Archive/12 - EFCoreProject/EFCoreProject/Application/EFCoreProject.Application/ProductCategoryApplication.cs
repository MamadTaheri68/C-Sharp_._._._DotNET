using EFCoreProject.Application.Contracts.ProductCategory;
using EFCoreProject.Domain.ProductCategoryAgg;

namespace EFCoreProject.Application
{
    public class ProductCategoryApplication : IProductCategoryApplication
    {
        private readonly IProductCategoryRepository _productCategoryRepository;

        public ProductCategoryApplication(IProductCategoryRepository productCategoryRepository)
        {
            _productCategoryRepository = productCategoryRepository;
        }
        public void Create(CreateProductCategory command)
        {
            if (_productCategoryRepository.Exists(command.Name))
                return;

            var productCategory = new ProductCategory(command.Name);
            _productCategoryRepository.Create(productCategory);
            _productCategoryRepository.SaveChanges();
        }

        public void edit(EditProductCategory command)
        {
            var productCategory = _productCategoryRepository.Get(command.Id);
            if (productCategory == null)
                return;
            productCategory.Edit(command.Name);
            _productCategoryRepository.SaveChanges();
        }

        public List<ProductCategoryViewModel> Search(string name)
        {
            return _productCategoryRepository.Search(name);
        }
    }
}