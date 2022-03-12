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
        bool Delete (int id);
        ICollection<DbEmployee> GetAllByCompanyId (int companyId);
        ICollection<DbEmployee> GetAllByDepartament (string departamentName);
        DbEmployee Update (DbEmployee entity);




    }
}
