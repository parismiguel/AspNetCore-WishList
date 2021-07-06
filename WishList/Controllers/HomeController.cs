using Microsoft.AspNetCore.Mvc;

namespace WishList.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(nameof(Index));
        }

        public IActionResult Error()
        {
            return View(nameof(Error));
        }
    }
}
