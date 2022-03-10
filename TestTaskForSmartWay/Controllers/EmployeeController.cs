using Microsoft.AspNetCore.Mvc;

namespace TestTaskForSmartWay.Controllers
{
    public class EmployeeController : Controller
    {
        [Route("api/v1/employee/{id}")]
        public IActionResult Echo(int id)
        {
            return Ok(id);
        }
        [Route("/")]
        public IActionResult Index()
        {
            return Ok("работает");
        }
    }
}
