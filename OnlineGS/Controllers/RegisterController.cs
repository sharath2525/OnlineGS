using Microsoft.AspNetCore.Mvc;

namespace OnlineGS.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
