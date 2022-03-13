using DataAccessLayer.Interfaces;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DataAccessLayer.Models;

namespace DataAccessLayer.Classes
{
    public class EmployeeDAL : IEmployeeDAL
    {
        public void Delete(int id)
        {
            using (var connection = DBConnection.CreateConnection())
            {
                var sql = "DELETE FROM public.\"Employees\" WHERE \"Id\" = '1'";
                connection.Execute(sql);
            }
        }


        public IEnumerable<DbEmployee> GetAllByCompanyId(int companyId)
        {
            using (var connection = DBConnection.CreateConnection())
            {
                var sql = $"SELECT * FROM public.\"Employees\" WHERE \"CompanyId\" = '{companyId}'";
                var employees = connection.Query<DbEmployee>(sql);                
                return employees;
            }
        }

        public IEnumerable<DbEmployee> GetAllByDepartamentName(string departamentName)
        {
            using (var connection = DBConnection.CreateConnection())
            {
                var sql = $"SELECT * FROM public.\"Employees\" WHERE \"DepartamentName\" = '{departamentName}'";
                var employees = connection.Query<DbEmployee>(sql);
                return employees;
            }
        }

        public int InsertPassport(DbPassport passport)
        {
            using (var connection = DBConnection.CreateConnection())
            {
                var sqlQueryAddPassport = $"INSERT INTO public.\"Passports\" (\"Type\", \"Number\", \"Id\") VALUES('{passport.Type}', '{passport.Number}', DEFAULT)  RETURNING \"Id\"";
                int passportId = connection.Query<int>(sqlQueryAddPassport).FirstOrDefault();
                return passportId;
            }

        }
        public int Insert(DbEmployee employee)
        {
            using (var connection = DBConnection.CreateConnection())
            {

                var sqlQuery = $"INSERT INTO public.\"Employees\" " +
                    $"(\"Name\", \"Surname\", \"DepartmentName\",\"CompanyId\", \"Phone\",\"PassportId\") " +
                    $"VALUES('{employee.Name}', '{employee.Surname}', '{employee.DepartmentName}', '{employee.CompanyId}', " +
                    $"'{employee.Phone}', '{employee.PassportId}') RETURNING \"Id\"";
                int userId = connection.Query<int>(sqlQuery, employee).FirstOrDefault();
                return userId;
            }
        }

        public DbEmployee Update(DbEmployee entity)
        {
            throw new NotImplementedException();
        }


        public DbPassport GetPassportById(int id)
        {
            using (var connection = DBConnection.CreateConnection())
            {
                var sql = $"SELECT * FROM public.\"Passports\" WHERE \"Id\" = '{id}'";
                return connection.Query<DbPassport>(sql).FirstOrDefault();
            }
    }

        public DbDepartament GetDepartmentByName(string name)
        {
            using (var connection = DBConnection.CreateConnection())
            {
                var sql = $"SELECT * FROM public.\"Departments\" WHERE \"Name\" = '{name}'";
                return connection.Query<DbDepartament>(sql).FirstOrDefault();
            }
        }
    }
