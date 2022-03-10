using Microsoft.AspNetCore.Mvc;

namespace TestTaskForSmartWay.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
