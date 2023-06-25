using Microsoft.AspNetCore.Mvc;

namespace Lab3.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Account()
        {
            return View();
        }
    }
}
