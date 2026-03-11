using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SklepSDUKW.DAL;
using SklepSDUKW.Models;

namespace SklepSDUKW.Controllers
{
    public class HomeController : Controller
    {
        FilmsContext db;

        public HomeController(FilmsContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var categories = db.Categories.ToList();

            return View(categories);
        }

        public IActionResult FooterSites(string name)
        {
            return View(name);
        }
        
    }
}
