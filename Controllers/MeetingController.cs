using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{

    public class MeetingController : Controller
    {
        //bu action methodlar bir get requesttir aksi belirtilmedikce defaultu [HttpGet]tir
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(string Name, string Phone, string Email, bool WillAttend)
        {
            Console.WriteLine($"Name: {Name}, Phone: {Phone}, Email: {Email}, WillAttend: {WillAttend}");
            return View();
        }

        [HttpGet]
        public IActionResult List()
        {
            return View();
        }
    }


}