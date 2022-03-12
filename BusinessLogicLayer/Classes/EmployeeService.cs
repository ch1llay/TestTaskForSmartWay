using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.Mappers;
using BusinessLogicLayer.Models;
using DataAccessLayer.Classes;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;

namespace BusinessLogicLayer.Classes
{

    public class EmployeeService : IEmployeeService
    {
        IEmployeeDAL _employeeDAL;
        public EmployeeService(EmployeeDAL employeeDAL)
        {
            _employeeDAL = employeeDAL;
        }
        public int Create(Employee employee, Passport passport)
        {
            employee.PassportId = _employeeDAL.InsertPassport(new DbPassport { Number = passport.Number, Type = passport.Type });
            return _employeeDAL.Insert(employee.ToDbEmployee());
        }
    }
}