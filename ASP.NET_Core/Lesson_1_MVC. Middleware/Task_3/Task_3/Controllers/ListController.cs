using Microsoft.AspNetCore.Mvc;

namespace Task_3.Controllers
{
    public class ListController : Controller
    {
        public IActionResult Info()
        {
            var items = new List<string> { "Item 1", "Item 2", "Item 3" };
            return View(items);
        }
    }
}
