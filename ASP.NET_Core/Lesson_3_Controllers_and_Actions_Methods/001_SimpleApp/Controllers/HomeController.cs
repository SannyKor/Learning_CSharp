using Microsoft.AspNetCore.Mvc;

namespace _001_SimpleApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _environment;

        public HomeController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Download()
        {
            string filePath = Path.Combine(_environment.ContentRootPath, "App_Data", "Task.png");
            if (!System.IO.File.Exists(filePath))
            {
                return NotFound("File not found.");
            }
            string contentType = "image/png";
            string fileName = "Lesson_3_Task_3.png";
            return PhysicalFile(filePath, contentType, fileName);
        }
    }
}
