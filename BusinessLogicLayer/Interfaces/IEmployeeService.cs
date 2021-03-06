using BusinessLogicLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interfaces
{
    public interface IEmployeeService
    {
        int Create(Employee employee, Passport passport);
        IEnumerable<Employee> GetAllByCompanyId(int companyId);
        IEnumerable<Employee> GetAllByDepartamentName(string departamentName);
        void Delete(int employeeId);
        void Update(int id, Employee employee);
    }
}
