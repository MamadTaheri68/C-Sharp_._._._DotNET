using EFCoreProject.Application.Contracts.Product;
using EFCoreProject.Domain.ProductAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreProject.Application
{
    public class ProductApplication : IProductApplication
    {
        private readonly IProductRepository _productRepository;

        public ProductApplication(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public void Create(CreateProduct command)
        {
            if (_productRepository.Exists(command.Name, command.CategoryId))
                return;
            var product = new Product(command.Name, command.UnitPrice, command.CategoryId);
            _productRepository.Create(product);
            _productRepository.SaveChanges();
        }

        public void Edit(EditProduct command)
        {
            var product = _productRepository.Get(command.Id);
            if (product == null)
                return;
            product.Edit(command.Name, command.UnitPrice, command.CategoryId);
            _productRepository.SaveChanges();
        }

        public EditProduct GetDetails(int id)
        {
            return _productRepository.GetDetails(id);
        }

        public void Remove(int id)
        {
            var product = _productRepository.Get(id);
            if (product == null)
                return;
            product.Remove();
            _productRepository.SaveChanges();
        }

        public void REstore(int id)
        {
            var product = _productRepository.Get(id);
            if (product == null)
                return;
            product.Restore();
            _productRepository.SaveChanges();
        }

        public List<ProductViewModel> Search(ProductSearchModel searchModel)
        {
            return _productRepository.Search(searchModel);
        }
    }
}
