using Microsoft.AspNetCore.Mvc;

namespace  MettingApp.Controllers 
{
    public class HomeController : Controller {
        public string Index() {
            return "home/index";
        }

    }
}