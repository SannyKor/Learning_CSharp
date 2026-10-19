using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        private List<Product> GenerateRandomProducts(int count = 5)
        {
            var random = new Random();
            var productNames = new[] { "Клавіатура", "Миша", "Монітор", "Навушники", "Ноутбук", "Килимок", "Колонки" };
            var products = new List<Product>();

            for (int i = 1; i <= count; i++)
            {
                products.Add(new Product
                {
                    Id = i,
                    Name = productNames[random.Next(productNames.Length)],
                    Price = Math.Round((decimal)(random.NextDouble() * (5000 - 100) + 100), 2)
                });
            }

            return products;
        }
        // 1. Спосіб: Строго типізоване подання
        [HttpGet]
        public IActionResult Index()
        {
            List<Product> products = GenerateRandomProducts(6);
            return View(products);
        }

        // 2. Спосіб: Передача через ViewBag
        [HttpGet]
        public IActionResult IndexWithViewBag()
        {
            List<Product> products = GenerateRandomProducts(6);
            ViewBag.ProductsList = products;
            return View();
        }
    }
}
