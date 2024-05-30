using CoffeeShopRegistration.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoffeeShopRegistration.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult CoffeeView()
        {
            return View();
        }
        public IActionResult Result(CoffeeModel c)
        {
            return View(c);
        }
        public IActionResult Index()
        {
            CoffeeModel c = new CoffeeModel();
            c.firstname = "k";
            c.lastname = "Lebowski";
            c.email = "J.Lebowski@gmail.com";
            c.password = "Thedudeabides24!";
            
            return View(c);
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
