using Microsoft.AspNetCore.Mvc;

namespace MettingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;

            // ViewBag.Selamlama = saat > 12 ? "Günaydın" : "İyi Günler";
            // ViewBag.Username = "Gül Sevim";

            ViewData["Selamlama"] = saat > 12 ? "Günaydın" : "İyi Günler";
            ViewData["Username"] = "Gül Sevim";


            return View();
        }

    }
}