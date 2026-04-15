using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SklepSDUKW.DAL;
using SklepSDUKW.Models.ViewModels;

namespace SklepSDUKW.Controllers
{
    public class FilmsController : Controller
    {
        FilmsContext db;
        IWebHostEnvironment hostEnvironment;

        public FilmsController(FilmsContext db, IWebHostEnvironment hostEnvironment)
        {
            this.db = db;
            this.hostEnvironment = hostEnvironment;
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

        [HttpGet]
        public IActionResult AddFilm()
        {
            var model = new AddFilmViewModel();

            model.Categories = db.Categories.ToList();

            return View(model);
        }

        [HttpPost]
        public IActionResult AddFilm(AddFilmViewModel model)
        {

            var picFolder = Path.Combine(hostEnvironment.WebRootPath, "content", "grafiki");

            var posterName = Guid.NewGuid() + "_" + model.Poster.FileName;

            var filePath = Path.Combine(picFolder, posterName);

            model.Poster.CopyTo(new FileStream(filePath, FileMode.Create));

            model.Film.Poster = posterName;

            db.Films.Add(model.Film);

            db.SaveChanges();

            return RedirectToAction("AllFilms");
        }
    }
}
