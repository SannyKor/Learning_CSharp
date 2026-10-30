using Microsoft.AspNetCore.Mvc;
using Task_2_WebCalculator.Services.Interfaces;

namespace Task_2_WebCalculator.Controllers
{
    public class CalcController : Controller
    {
        private readonly ICalcService _calcService;

        // Впровадження залежності через конструктор
        public CalcController(ICalcService calcService)
        {
            _calcService = calcService;
        }

        // Головна сторінка з формою
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // GET: /Calc/Add?a=10&b=5
        [HttpGet]
        public IActionResult Add(double a, double b)
        {
            double result = _calcService.Add(a, b);
            ViewBag.Operation = $"{a} + {b}";
            ViewBag.Result = result;
            return View("Result");
        }

        // GET: /Calc/Subtract?a=10&b=5
        [HttpGet]
        public IActionResult Subtract(double a, double b)
        {
            double result = _calcService.Subtract(a, b);
            ViewBag.Operation = $"{a} - {b}";
            ViewBag.Result = result;
            return View("Result");
        }

        // GET: /Calc/Multiply?a=10&b=5
        [HttpGet]
        public IActionResult Multiply(double a, double b)
        {
            double result = _calcService.Multiply(a, b);
            ViewBag.Operation = $"{a} * {b}";
            ViewBag.Result = result;
            return View("Result");
        }

        // GET: /Calc/Divide?a=10&b=5
        [HttpGet]
        public IActionResult Divide(double a, double b)
        {
            if (b == 0)
            {
                ViewBag.Error = "Помилка: ділення на нуль неможливе.";
                return View("Result");
            }

            double result = _calcService.Divide(a, b);
            ViewBag.Operation = $"{a} / {b}";
            ViewBag.Result = result;
            return View("Result");
        }
    }
}
