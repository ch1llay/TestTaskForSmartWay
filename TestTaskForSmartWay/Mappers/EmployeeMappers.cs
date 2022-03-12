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
    }
}

