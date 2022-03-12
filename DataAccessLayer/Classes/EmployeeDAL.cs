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
                var sqlQueryPassport = "INSERT INTO Passports (Type, Number) VALUES(@Name, @Number);SELECT CAST(SCOPE_IDENTITY() as int";
                int passportId = connection.Query<int>(sqlQueryPassport, passport).FirstOrDefault();
                return passportId;
            }
            
        }
        public int Insert(DbEmployee employee)
        {
            using (var connection = DBConnection.CreateConnection())
            {

                var sqlQuery = "INSERT INTO Employees (Name, Surname, PassportId) VALUES(@Name, @Surname, @PassportId); SELECT CAST(SCOPE_IDENTITY() as int";
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
