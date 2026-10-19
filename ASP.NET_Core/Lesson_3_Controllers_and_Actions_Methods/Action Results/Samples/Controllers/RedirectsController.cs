using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ActionResultsSamples.Controllers
{
    public class RedirectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sample1()
        {
            // перенаправлення за допомогою коду 302. Тимчасове перенаправлення.
            return Redirect("http://itvdn.com");
        }

        public IActionResult Sample2()
        {
            // перенаправлення за допомогою коду 302. Тимчасове перенаправлення.
            return Redirect("/home/index");
        }

        public IActionResult Sample3()
        {
            // перенаправлення за допомогою коду 301. Постійне перенаправлення.
            return RedirectPermanent("/home/index");
        }

        public IActionResult Sample4()
        {
            return RedirectToAction("Index"); // перенаправлення на метод Index поточного контролера
        }

        public IActionResult Sample5()
        {
            return RedirectToAction("Index", "Home"); // перенаправлення на метод Index контролера Home
        }

        public IActionResult Sample6()
        {
            // Перенаправлення з використанням значень для змінних сегментів
            return RedirectToRoute(new { controller = "home", action = "index" });
        }
    }
}