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
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }


        public ICollection<DbEmployee> GetAllByCompanyId(int companyId)
        {
            throw new NotImplementedException();
        }

        public ICollection<DbEmployee> GetAllByDepartament(string departamentName)
        {
            throw new NotImplementedException();
        }

        public int InsertPassport(DbPassport passport)
        {
            using (var connection = DBConnection.CreateConnection())
            {
                var getAllTabels = "SELECT table_schema || '.' || table_name FROM information_schema.tables WHERE table_type = 'BASE TABLE' AND table_schema NOT IN ('pg_catalog', 'information_schema');";
                var s = connection.Query(getAllTabels).ToList();
                string quote = "\"";
                var sqlQueryAddPassport = $"INSERT INTO public.\"Passports\" (\"Type\", \"Number\", \"Id\") VALUES('{passport.Type}', '{passport.Number}', DEFAULT)  RETURNING \"Id\"";
                int passportId = connection.Query<int>(sqlQueryAddPassport).FirstOrDefault();
                return passportId;
            }
            
        }
        public int Insert(DbEmployee employee)
        {
            using (var connection = DBConnection.CreateConnection())
            {

                var sqlQuery = $"INSERT INTO public.\"Employees\" (\"Name\", \"Surname\", \"PassportId\") VALUES('{employee.Name}', '{employee.Surname}', '{employee.PassportId}') RETURNING \"Id\"";
                int userId = connection.Query<int>(sqlQuery, employee).FirstOrDefault();
                return userId;
            }
        }

        public DbEmployee Update(DbEmployee entity)
        {
            throw new NotImplementedException();
        }
    }
}
