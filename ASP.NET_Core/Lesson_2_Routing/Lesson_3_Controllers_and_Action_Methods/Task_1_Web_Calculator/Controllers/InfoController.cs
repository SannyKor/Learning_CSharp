using Microsoft.AspNetCore.Mvc;
using Task_1_Web_Calculator.Models;

namespace Task_1_Web_Calculator.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult Index()
        {
            var model = new ClientInfoViewModel
            {
                IpAddress = HttpContext.Connection.RemoteIpAddress?.ToString(),

                UserAgent = Request.Headers.UserAgent.ToString()
            };
            if (string.IsNullOrEmpty(model.IpAddress) || model.IpAddress == "::1")
            {
                model.IpAddress = "127.0.0.1 (Localhost)";
            }
            return View(model);
        }
    }
}
