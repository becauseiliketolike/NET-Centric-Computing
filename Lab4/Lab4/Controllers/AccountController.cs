using Microsoft.AspNetCore.Mvc;

namespace Lab4.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
