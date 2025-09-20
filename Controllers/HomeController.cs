using MeetingApp.Models;
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
            // ViewData["Username"] = "Gül Sevim";

            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "İstanbul Ofis",
                Date = new DateTime(2024, 7, 15, 14, 0, 0),
                NumberOfPeople = 100
            };


            return View(meetingInfo);
        }

    }
}