using EFCore_TestProject.DataAccessLayer;
using EFCore_TestProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EFCore_TestProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ShopDbContext _shopDbContext;

        public HomeController(ShopDbContext shopDbContext)
        {
            _shopDbContext = shopDbContext;
        }

        public IActionResult Index()
        {
            //var product = new Product("Mac Book Pro", 3999);
            //product.SetDiscountRate(6);
            //_shopDbContext.Add(product);

            //var product2 = new Product("Ipad", 1999);
            //product2.SetDiscountRate(3);
            //_shopDbContext.Products.Add(product2);

            //var product3 = new Product("Galaxy s20", 699);
            //_shopDbContext.Products.Add(product3);

            //_shopDbContext.SaveChanges();

            //var products = _shopDbContext.Products.ToList(); // Select All

            //var product = _shopDbContext.Products.FirstOrDefault(); // First record of table
            //var product = _shopDbContext.Products.FirstOrDefault(q => q.Id == 2); // First record of table with condition
            //var product = _shopDbContext.Products.FirstOrDefault(q => q.Id == 15); // null
            //var product = _shopDbContext.Products.First(q => q.Id == 15); // Exception
            //var product = _shopDbContext.Products.First(q => q.Id == 3); // first elemnet of sequence
            //var roduct = _shopDbContext.Products.FirstOrDefault(q => q.Name == "Ipad");
            //var roduct = _shopDbContext.Products.FirstOrDefault(q => q.IsInStock == true && q.DiscountRate > 0);

            //var product = _shopDbContext.Products.SingleOrDefault(q => !q.IsInStock);
            //var product = _shopDbContext.Products.Single(q => q.Id == 15);

            // Just searches for primary key
            //var product = _shopDbContext.Products.Find(Convert.ToInt64(2));

            // List
            //var products = _shopDbContext.Products.ToList();
            //var products = _shopDbContext.Products.Where(q => q.UnitPrice < 1000).ToList();
            //var products = _shopDbContext.Products
            //    .Where(q => q.UnitPrice < 1000)
            //    .Where(q => q.IsInStock)
            //    .ToList();
            var products = _shopDbContext.Products
               .Where(q => q.UnitPrice >700)
               .ToList();

            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}