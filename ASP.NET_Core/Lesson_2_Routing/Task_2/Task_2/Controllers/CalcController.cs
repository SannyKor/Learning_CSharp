using Microsoft.AspNetCore.Mvc;

namespace Task_2.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Add (int a, int b)
        {
            int result = a + b;
            return View(result);
        }
        public IActionResult Subtract(int a, int b)
        {
            int result = a - b;
            return View(result);
        }
        public IActionResult Multiply(int a, int b)
        {
            int result = a * b;
            return View(result);
        }
        public IActionResult Divide(int a, int b)
        {
            if (b == 0)
            {
                ViewBag.HasError = true;
                ViewBag.ErrorMessage = "Cannot divide by zero.";
                return View();
            }
            ViewBag.HasError = false;
            ViewBag.Result = a / b;
            return View();
        }
    }
}
