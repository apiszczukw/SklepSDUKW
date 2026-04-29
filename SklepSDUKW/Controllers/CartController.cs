using Microsoft.AspNetCore.Mvc;
using SklepSDUKW.DAL;
using SklepSDUKW.Infrastructure;
using SklepSDUKW.Models.ViewModels;

namespace SklepSDUKW.Controllers
{
    public class CartController : Controller
    {
        FilmsContext db;

        public CartController(FilmsContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var cart = CartManager.GetItems(HttpContext.Session);
            ViewBag.Total = CartManager.GetCartTotalValue(HttpContext.Session);


            return View(cart);
        }


        public IActionResult AddToCart(int id)
        {
            CartManager.AddToCart(HttpContext.Session, db, id);

            return RedirectToAction("Index");
        }


        public IActionResult RemoveFromCart(int id)
        {
            var model = new RemoveViewModel()
            {
                itemId = id,
                itemQuantity = CartManager.RemoveFromCart(HttpContext.Session, id),
                cartValue = CartManager.GetCartTotalValue(HttpContext.Session)
            };

            return Json(model);
        }
    }
}
