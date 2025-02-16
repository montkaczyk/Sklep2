using Microsoft.AspNetCore.Mvc;
using sklep.Models;

namespace sklep.Controllers
{
    public class RegistrationController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(string email, bool consent, int age)
        {
            if (age < 18)
                this.ViewBag.Message = "You need to be older than 18 years to register here! ";
            else if (consent == false)
                this.ViewBag.Message = "Consent not provided!";
            else
                this.ViewBag.Message = $"User {email} registered!";

            return View("Index");
        }
    }
}
