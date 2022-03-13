using BusinessLogicLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using TestTaskForSmartWay.Models;
using TestTaskForSmartWay.Mappers;

namespace TestTaskForSmartWay.Controllers
{
    [ApiController]
    [Produces("application/json")]
    public class EmployeeController : Controller
    {
        IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpPost]
        [Route("api/v1/employee/")]
        public IActionResult Create([FromBody] RequestCreateEmployee employee)
        {

            return Ok(_employeeService.Create(employee.ToEmployee(), employee.Passport));
        }

        [HttpDelete]
        [Route("api/v1/employee/")]
        public IActionResult Delete([FromQuery] int employeeId)
        {
            _employeeService.Delete(employeeId);

            return Ok();
        }


        [HttpPut]
        [Route("api/v1/employee/{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] RequestUpdateEmployee employee)
        {
            _employeeService.Update(id, employee.ToEmployee());
            return Ok(employee.Name);
        }

        [HttpGet]
        [Route("api/v1/employee/getByCompanyId")]
        public IActionResult GetAllByCompanyId([FromQuery] int companyId)
        {

            return Ok(_employeeService.GetAllByCompanyId(companyId));
        }
        [HttpGet]
        [Route("api/v1/employee/getByDepartmentName")]
        public IActionResult GetAllByDepartmentName([FromQuery] string departmentName)
        {

            return Ok(_employeeService.GetAllByDepartamentName(departmentName));
        }




        [Route("/")]
        public IActionResult Index()
        {
            return Ok("работает");
        }


    }
}
