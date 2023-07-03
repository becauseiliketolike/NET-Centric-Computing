using Microsoft.AspNetCore.Mvc;

namespace Lab4b.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome()
        {
            ViewData["Message"] = "Hello Norden";
            ViewData["NumTimes"] = 10;
            return View();
        }
        public IActionResult Google()
        {
            return Redirect("https://www.google.com/");
        }
    }
}
