using Microsoft.AspNetCore.Mvc;
using Task_1_Web_Calculator.Models;

namespace Task_1_Web_Calculator.Controllers
{
    public class CalculatorController : Controller
    {public IActionResult Index(Calculator calculator)
        {
            if (string.IsNullOrEmpty(calculator.Operation) || !calculator.FirstNumber.HasValue || !calculator.SecondNumber.HasValue)
            {
                return View(calculator);
            }
            switch (calculator.Operation)
            {
                case "+":
                    calculator.Result = calculator.FirstNumber + calculator.SecondNumber;
                    break;
                case "-":
                    calculator.Result = calculator.FirstNumber - calculator.SecondNumber    ;
                    break;
                case "*":
                    calculator.Result = calculator.FirstNumber * calculator.SecondNumber;
                    break;
                case "/":
                    if (calculator.SecondNumber == 0)
                    {
                        calculator.ErrorMessage = "Cannot divide by zero.";
                    }
                    calculator.Result = calculator.FirstNumber / calculator.SecondNumber;
                    break;
                default:
                    calculator.ErrorMessage = "Invalid operation.";
                    break;
            }
            return View(calculator);
        }
    }
}
