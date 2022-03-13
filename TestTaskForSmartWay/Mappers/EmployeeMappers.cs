using BusinessLogicLayer.Models;
using DataAccessLayer;
using DataAccessLayer.Classes;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskForSmartWay.Models;

namespace TestTaskForSmartWay.Mappers
{
    public static class EmployeeMappers
    {
        public static Employee ToEmployee(this RequestCreateEmployee source)
        {
            return new Employee
            {
                CompanyId = source.CompanyId,
                DepartmentName = source.DepartmentName,
                Name = source.Name,
                Surname = source.Surname,
                Phone = source.Phone
            };
        }
        public static EmployeeResponse ToResponse(this Employee source)
        {
            return new EmployeeResponse
            {
                CompanyId = source.CompanyId,
                Name = source.Name,
                Surname = source.Surname,
                Phone = source.Phone,
                Passport = source.Passport,
                Department = source.Department
            };
        }




    }
}

