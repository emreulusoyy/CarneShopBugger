using Microsoft.AspNetCore.Mvc;

namespace CarneShopBugger.Controllers
{
    public class UrunlerimizController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
