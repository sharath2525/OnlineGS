using Microsoft.AspNetCore.Mvc;

namespace OnlineGS.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
