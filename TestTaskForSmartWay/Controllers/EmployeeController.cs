using BusinessLogicLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using TestTaskForSmartWay.Models;
using TestTaskForSmartWay.Mappers;

namespace TestTaskForSmartWay.Controllers
{
    public class EmployeeController : Controller
    {
        IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [Route("api/v1/employee/{id}")]
        public IActionResult Echo(int id)
        {
            return Ok(id);
        }
        [Route("api/v1/employee/create")]
        public IActionResult Create([FromBody] RequestCreateEmployee employee)
        {

            return Ok(_employeeService.Create(employee.ToEmployee(), employee.Passport));
        }
            
        [Route("/")]
        public IActionResult Index()
        {
            return Ok("работает");
        }


    }
}
