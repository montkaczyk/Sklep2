using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using sklep.Models;

namespace sklep.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int Age = 18)
        {
            string category = this.Request.Query["Category"].ToString();
            if (string.IsNullOrEmpty(category))
                category = "All Products";
            ViewData["Category"] = category;

            if (Age < 18)
                return View("Under"); 
            else
                return View("Above"); 
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
