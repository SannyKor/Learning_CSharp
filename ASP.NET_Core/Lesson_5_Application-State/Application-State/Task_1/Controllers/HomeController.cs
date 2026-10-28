using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace Task_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMemoryCache _cache;
        private const string CacheKey = "OnlineUsersCount";
        private static readonly object _lock = new();

        public HomeController(IMemoryCache cache)
        {
            _cache = cache;
        }

        public IActionResult Index()
        {
            // Перевіряємо сесію поточного браузера
            if (HttpContext.Session.GetString("IsCounted") == null)
            {
                // Якщо браузер зайшов уперше — ставимо мітку в його персональну сесію
                HttpContext.Session.SetString("IsCounted", "true");

                // Потокобезпечно збільшуємо спільне число в кеші
                lock (_lock)
                {
                    int currentCount = _cache.GetOrCreate(CacheKey, entry => 0);
                    _cache.Set(CacheKey, currentCount + 1);
                }
            }

            // Читаємо спільне значення з кешу для відображення
            ViewBag.OnlineUsersCount = _cache.Get<int>(CacheKey);

            return View();
        }
    }
}
