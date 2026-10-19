using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ActionResultsSamples.Controllers
{
    public class JsonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShowList()
        {
            return View();
        }

        public IActionResult ClientInfo()
        {
            var client = new Client()
            {
                Id = 100,
                Login = "user1",
                Email = "user1@example.com"
            };

            // Json - Серіалізує об'єкт переданий у параметрах JSON і повертає клієнту відповідь.
            return Json(client);
        }

        public IActionResult ClientInfo2()
        {
            // використання анонімних типів для формування JSON відповіді
            return Json(new
            {
                Id = 100,
                Login = "user1",
                Email = "user1@example.com"
            });
        }
        public IActionResult ClientsList()
        {
            var clients = new List<Client>
            {
                new Client { Id = 101, Login = "user1", Email = "user1@example.com" },
                new Client { Id = 102, Login = "user2", Email = "user2@example.com" },
                new Client { Id = 103, Login = "user3", Email = "user3@example.com" }
            };

            return Json(clients);
        }
    }

    public class Client
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
    }
}
