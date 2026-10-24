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
            return RedirectToAction(nameof(SubPage1));
        }
        public IActionResult SubPage1()
        {
            ViewBag.Message = "Текст підрозділу: Меню 1";
            return View();
        }

        public IActionResult SubPage2()
        {
            ViewBag.Message = "Текст підрозділу: Меню 2";
            return View();
        }

        public IActionResult SubPage3()
        {
            ViewBag.Message = "Текст підрозділу: Меню 3";
            return View();
        }
    }
}
