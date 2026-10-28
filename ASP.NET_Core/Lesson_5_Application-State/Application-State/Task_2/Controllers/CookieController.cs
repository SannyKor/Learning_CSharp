using Microsoft.AspNetCore.Mvc;
using Task_2.Models;

namespace Task_2.Controllers
{
    public class CookieController : Controller
    {
        private const string CookieKey = "UserCustomCookie";

        [HttpGet]
        public IActionResult Create()
        {
            return View(new CookieFormViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CookieFormViewModel model)
        {
            if (model.ExpirationDate <= DateTime.Now)
            {
                ModelState.AddModelError(nameof(model.ExpirationDate), "Дата повинна бути більшою за поточний час");
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var options = new CookieOptions
            {
                Expires = model.ExpirationDate,
                HttpOnly = true,
                IsEssential = true
            };

            Response.Cookies.Append(CookieKey, model.CookieValue, options);

            return RedirectToAction(nameof(Check));
        }

        [HttpGet]
        public IActionResult Check()
        {
            var cookieExists = Request.Cookies.TryGetValue(CookieKey, out var value);

            ViewBag.Exists = cookieExists;
            ViewBag.Value = value;

            return View();
        }
    }
}
