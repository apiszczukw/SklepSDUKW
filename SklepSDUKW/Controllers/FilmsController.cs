using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SklepSDUKW.DAL;

namespace SklepSDUKW.Controllers
{
    public class FilmsController : Controller
    {
        FilmsContext db;

        public FilmsController(FilmsContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryFilms(string categoryName)
        {
            var category = db.Categories.Include(c => c.Films).Where(c => c.Name.ToUpper() == categoryName.ToUpper()).Single();

            var films = category.Films.ToList();

            return View(films);
        }

        public IActionResult AllFilms()
        {
            var films = db.Films.OrderBy(c=>c.CategoryId).ThenBy(t => t.Title).ToList();

            return View(films);
        }

        public IActionResult Details(int filmId)
        {
            var film = db.Films.Find(filmId);
            db.Categories.Find(film?.CategoryId);

            return View(film);
        }
    }
}
