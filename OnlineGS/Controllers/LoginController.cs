using Microsoft.AspNetCore.Mvc;

namespace OnlineGS.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
