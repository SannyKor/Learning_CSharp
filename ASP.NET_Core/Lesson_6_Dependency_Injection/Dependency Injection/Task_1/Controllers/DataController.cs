using Microsoft.AspNetCore.Mvc;
using Task_1.Interfaces;

namespace Task_1.Controllers
{
    public class DataController : Controller
    {
        private readonly IDataListService _dataListService;

        public DataController(IDataListService dataListService)
        {
            _dataListService = dataListService;
        }

        public IActionResult Index()
        {
            IEnumerable<string> items = _dataListService.GetItems();
            return View(items);
        }
    }
}
