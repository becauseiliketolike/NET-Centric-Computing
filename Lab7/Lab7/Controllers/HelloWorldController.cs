using Microsoft.AspNetCore.Mvc;

namespace Lab7.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(String name, int numTimes = 10) 
        {
            ViewData["Message"] =  "Hello" + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }

        public IActionResult Google() {
            return Redirect("https://www.google.com/");
        }
    }
}
