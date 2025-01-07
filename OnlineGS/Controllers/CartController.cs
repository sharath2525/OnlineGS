using Microsoft.AspNetCore.Mvc;

namespace OnlineGS.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Cart()
        {
            return View();
        }
    }
}
