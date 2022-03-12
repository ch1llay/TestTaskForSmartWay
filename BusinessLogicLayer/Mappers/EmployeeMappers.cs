using BusinessLogicLayer.Models;
using DataAccessLayer;
using DataAccessLayer.Classes;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Mappers
{
    public static class EmployeeMappers
    {
        public static DbEmployee ToDbEmployee(this Employee source)
        {
            return new DbEmployee
            {
                Id = source.Id,
                CompanyId = source.CompanyId,
                DepartmentName = source.DepartmentName,
                PassportId = source.PassportId,
                Name = source.Name,
                Surname = source.Surname,
                Phone = source.Phone
            };
        }
    }
}

