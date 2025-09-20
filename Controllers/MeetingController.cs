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
        [HttpGet]
        public IActionResult List()
        {
            return View();
        }
    }


}