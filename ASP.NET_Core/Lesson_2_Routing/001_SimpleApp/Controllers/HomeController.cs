using Microsoft.AspNetCore.Mvc;

namespace _001_SimpleApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
