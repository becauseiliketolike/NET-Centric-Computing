using Microsoft.AspNetCore.Mvc;

namespace Lab2b.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Account()
        {
            return View();
        }
    }
}
