using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{

    public class MeetingController : Controller
    {
        //bu action methodlar bir get requesttir aksi belirtilmedikce defaultu [HttpGet]tir

        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(UserInfo model)
        {
            // Console.WriteLine($"Name: {Name}, Phone: {Phone}, Email: {Email}, WillAttend: {WillAttend}");
            Repository.CreateUser(model);
            ViewBag.UserCount = Repository.Users.Where(info =>info.WillAttend == true).Count();
            return View("Thanks", model);
        }

        [HttpGet]
        public IActionResult List()
        {
            return View();
        }
    }


}