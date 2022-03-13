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
    public static class Mappers
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
        public static Passport ToPassport(this DbPassport source)
        {
            return new Passport
            {
                Number = source.Number,
                Type = source.Type
            };
        }
        public static DbPassport ToDbPassport(this Passport source)
        {
            return source != null ? new DbPassport
            {
                Id = source.Id,
                Number = source.Number,
                Type = source.Type
            } : null ;
        }
        public static Departament ToDepartament(this DbDepartament source)
        {
            return new Departament
            {
                Name = source.Name,
                Phone = source.Phone
            };
        }
        public static Employee ToEmployee(this DbEmployee source, Passport passport=null, Departament departament=null)
        {
            return new Employee
            {
                Id = source.Id,
                CompanyId = source.CompanyId,
                DepartmentName = source.DepartmentName,
                PassportId = source.PassportId,
                Name = source.Name,
                Surname = source.Surname,
                Phone = source.Phone,
                Passport = passport,
                Department = departament
            };
        }
    }
}

