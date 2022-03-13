﻿using BusinessLogicLayer.Interfaces;
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
        [Route("api/v1/employee/")]
        public IActionResult Update([FromBody] RequestCreateEmployee employee)
        {

            return Ok(_employeeService.Update(employee.ToEmployee(), employee.Passport));
        }

        [HttpGet]
        [Route("api/v1/employee/")]
        public IActionResult GetAllByCompanyId([FromQuery] int companyId)
        {

            return Ok(_employeeService.GetAllByCompanyId(companyId));
        }
        [HttpGet]
        [Route("api/v1/employee/")]
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
