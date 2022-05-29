using Microsoft.AspNetCore.Mvc;
using MyPortfolioMVC.Models;
using System.Diagnostics;

namespace MyPortfolioMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Portfoli> _portfolios = new List<Portfoli>
        {
            new Portfoli
            {
                Id = 1, Title = "نمونه یک", Image = "01.jpg", Description = "این اولین پروژه است"
            },
            new Portfoli
            {
                Id = 2, Title = "نمونه دو", Image = "02.jpg", Description = "این دومین پروژه است"
            },
            new Portfoli
            {
                Id = 3, Title = "نمونه سه", Image = "03.jpg", Description = "این سومین پروژه است"
            },
            new Portfoli
            {
                Id = 4, Title = "نمونه چهار", Image = "04.jpg", Description = "این چهارمین پروژه است"
            }
        };

        public IActionResult Index()
        {
            ViewData["headingTitle"] = "به سایت شخصی من خوش آمدید";
            ViewData["headingText"] = "این سایت جهت نمونه کار آماده گردیده است";
            ViewBag.aaa = "لورم ایپسوم";
            return View(_portfolios);
        }

        public IActionResult Contact()
        {
            var contact = new Contact()
            {
                Email = "mamad.taheri@gmail.com",
                Mobile = "09123456789",
                Github = "https://github.com/MamadTaheri68"
            };
            return View(contact);
        }
        

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}