using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IEmployeeDAL
    {
        int Insert (DbEmployee employee);
        public int InsertPassport(DbPassport passport);
        public DbPassport GetPassportById(int id);
        public DbDepartament GetDepartmentByName(string name);
        void Delete (int id);
        IEnumerable<DbEmployee> GetAllByCompanyId (int companyId);
        IEnumerable<DbEmployee> GetAllByDepartamentName (string departamentName);
        DbEmployee Update (DbEmployee entity);




    }
}
