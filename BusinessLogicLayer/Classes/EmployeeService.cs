using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.Mappers;
using BusinessLogicLayer.Models;
using DataAccessLayer.Classes;
using DataAccessLayer.Interfaces;

namespace BusinessLogicLayer.Classes
{
    public class EmployeeService : IEmployeeService
    {
        IEmployeeDAL _employeeDAL;
        public EmployeeService(EmployeeDAL employeeDAL)
        {
            _employeeDAL = employeeDAL;
        }
        public int Create(Employee employee)
        {
            return _employeeDAL.Insert(employee.ToDbEmployee());
        }
    }
}