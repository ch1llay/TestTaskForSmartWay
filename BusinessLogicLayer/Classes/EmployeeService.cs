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
        public EmployeeService(IEmployeeDAL employeeDAL)
        {
            _employeeDAL = employeeDAL;
        }
        public int Create(Employee employee, Passport passport)
        {
            employee.PassportId = _employeeDAL.InsertPassport(new DbPassport { Number = passport.Number, Type = passport.Type });
            return _employeeDAL.Insert(employee.ToDbEmployee());
        }

        public IEnumerable<Employee> GetAllByCompanyId(int companyId)
        {
            return _employeeDAL.GetAllByCompanyId(companyId).Select(x => x.ToEmployee(
                _employeeDAL.GetPassportById(x.PassportId).ToPassport(), _employeeDAL.GetDepartmentByName(x.DepartmentName).ToDepartament()
                )
            );
        }
        public IEnumerable<Employee> GetAllByDepartamentName(string departamentName)
        {
            return _employeeDAL.GetAllByDepartamentName(departamentName).Select(x => x.ToEmployee(
                _employeeDAL.GetPassportById(x.PassportId).ToPassport(), _employeeDAL.GetDepartmentByName(x.DepartmentName).ToDepartament()
                )
            );
        }

    }
}