using Microsoft.AspNetCore.Mvc;

namespace Task_3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Вітаю на головній сторінці!";
            return View();
        }
        public IActionResult Page1()
        {
            ViewBag.Message = "Вітаю на сторінці 1!";
            return View();
        }
        public IActionResult Page2()
        {
            ViewBag.Message = "Вітаю на сторінці 2!";
            return View();
        }
    }
}
