using Microsoft.AspNetCore.Mvc;

namespace Task_3.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Message()
        {
            return View();
        }
    }
}
