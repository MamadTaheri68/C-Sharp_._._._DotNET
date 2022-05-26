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
            var product = new Product("Iphone 11", 999);
            _shopDbContext.Add(product);
            _shopDbContext.SaveChanges();
            return View();
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