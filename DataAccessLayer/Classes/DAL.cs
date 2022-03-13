using DataAccessLayer.Interfaces;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DataAccessLayer.Models;
using System.Reflection;

namespace DataAccessLayer.Classes
{
    public class DAL : IDAL
    {
        public void Delete(int employeeId)
        {
            using (var connection = DBConnection.CreateConnection())
            {
                var sql = $"DELETE FROM public.\"Employees\" WHERE \"Id\" = '{employeeId}'";
                connection.Execute(sql);
            }
        }

        public DbEmployee GetById(int employeeId)
        {
            using (var connection = DBConnection.CreateConnection())
            {
                var sql = $"SELECT * FROM public.\"Employees\" WHERE \"Id\" = '{employeeId}'";
                var employee = connection.Query<DbEmployee>(sql).Single();
                return employee;
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
                var sql = $"SELECT * FROM public.\"Employees\" WHERE \"DepartmentName\" = '{departamentName}'";
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

        public void UpdatePassport(DbPassport entity)
        {
            using (var connection = DBConnection.CreateConnection())
            {
                var sql = new StringBuilder($"update public.\"Employees\"  set ");
                Type myType = typeof(DbPassport);
                foreach (FieldInfo field in myType.GetFields())
                {
                    if (field.Name != "Id")
                    {
                        var value = myType.GetField(field.Name)?.GetValue(entity);
                        if (value != default)
                        {
                            sql.Append($" \"{field.Name}\" = '{value}', ");
                        }
                    }
                }
                sql[sql.Length - 2] = ' ';
                sql.Append("where \"Id\" = {entity.Id}");
                connection.Execute(sql.ToString());
            }


        }
        public void Update(DbEmployee entity)
        {
            using (var connection = DBConnection.CreateConnection())
            {
                DbEmployee employee = GetById(entity.Id);
                if(entity.PassportId != default && entity.PassportId != employee.PassportId)
                {
                    employee.PassportId = entity.PassportId;
                }
                if (entity.Name != default && entity.Name != employee.Name)
                {
                    employee.Name = entity.Name;
                }
                if (entity.Surname != default && entity.Surname != employee.Surname)
                {
                    employee.Surname = entity.Surname;
                }
                if (entity.DepartmentName != default && entity.DepartmentName != employee.DepartmentName)
                {
                    employee.DepartmentName = entity.DepartmentName;
                }
                if (entity.Phone != default && entity.Phone != employee.Phone)
                {
                    employee.Phone = entity.Phone;
                }




                var sql = $"Update public.\"Employees\" set \"Name\"='{employee.Name}', " +
                    $"\"Surname\"= '{employee.Surname}', \"DepartmentName\" = '{employee.DepartmentName}' ," +
                    $"\"CompanyId\"='{employee.CompanyId}', \"Phone\" = '{employee.Phone}', \"PassportId\" = '{employee.PassportId}' where \"Id\" = '{entity.Id}' ";

                /*var sql = new StringBuilder($"update public.\"Employees\"  set ");
                Type myType = typeof(DbEmployee);
                foreach (FieldInfo field in myType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static))
                {
                    if (field.Name != "Id")
                    {
                        var value = myType.GetField("Name")?.GetValue(entity);
                        if (value != default)
                        {
                            sql.Append($" \"{field.Name}\" = '{value}', ");
                        }
                    }
                }
                sql[sql.Length - 2] = ' ';
                sql.Append("where \"Id\" = {entity.Id}");*/
                connection.Execute(sql);
            }
            
            
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
}
