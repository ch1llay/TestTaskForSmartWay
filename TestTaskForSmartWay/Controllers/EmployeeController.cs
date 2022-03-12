using Microsoft.AspNetCore.Mvc;
using TestTaskForSmartWay.Models;

namespace TestTaskForSmartWay.Controllers
{
    public class EmployeeController : Controller
    {
        [Route("api/v1/employee/{id}")]
        public IActionResult Echo(int id)
        {
            return Ok(id);
        }
        [Route("api/v1/employee/create")]
        public IActionResult Create([FromBody] RequestCreateEmployee employee)
        {
            
        }
        [Route("/")]
        public IActionResult Index()
        {
            return Ok("работает");
        }


    }
}
