using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.IO;

namespace ActionResultsSamples.Controllers
{
    public class FilesController : Controller
    {
        private readonly IHostEnvironment _environment;

        public FilesController(IHostEnvironment environment)
        {
            _environment = environment;
        }

        public IActionResult Index()
        {
            return View();
        }

        // FileContentResult
        public IActionResult Sample1()
        {
            byte[] fileContent = System.IO.File.ReadAllBytes("App_Data/document.pdf");
            // Якщо вказати ім'я третім параметром, браузер зберігатиме файл навіть якщо підтримує формат і може його відкрити.
            // Якщо ім'я не вказано - браузер завантажує та зберігає файл у тому випадку, якщо не підтримує формат і не може його прочитати.
            return File(fileContent, "application/pdf", "Saved PDF File.pdf");
        }

        // FileStreamResult
        public IActionResult Sample2()
        {
            FileStream fileStream = System.IO.File.OpenRead("App_Data/document.pdf");
            return File(fileStream, "application/pdf");
        }

        // PhysicalFileResult
        public IActionResult Sample3()
        {
            // environment.ContentRootPath - абсолютний шлях до директорії у якому зберігається контент програми.
            return PhysicalFile(_environment.ContentRootPath + @"\App_Data\document.pdf", "application/pdf");
        }
    }
}