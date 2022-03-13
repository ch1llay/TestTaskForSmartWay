using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IDAL
    {
        int Insert (DbEmployee employee);
        public int InsertPassport(DbPassport passport);
        public DbPassport GetPassportById(int id);
        public DbDepartament GetDepartmentByName(string name);
        void Delete (int employeeId);
        IEnumerable<DbEmployee> GetAllByCompanyId (int companyId);
        IEnumerable<DbEmployee> GetAllByDepartamentName (string departamentName);
        void Update (DbEmployee entity);
        void UpdatePassport(DbPassport entity);
        DbEmployee GetById(int employeeId);




    }
}
