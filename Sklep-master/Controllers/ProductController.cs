using Microsoft.AspNetCore.Mvc;
using sklep.Data;
using sklep.Models;
using System.Linq;

namespace sklep.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult SeedCategories()
        {
            if (!_context.Categories.Any())
            {
                var categories = new[]
                {
                    new Category { Name = "Electronics" },
                    new Category { Name = "Books" },
                    new Category { Name = "Clothing" }
                };

                _context.Categories.AddRange(categories);
                _context.SaveChanges();
            }

            return RedirectToAction("List");
        }
    }
}
