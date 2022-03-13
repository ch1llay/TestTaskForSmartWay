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
        IDAL _DAL;
        public EmployeeService(IDAL DAL)
        {
            _DAL = DAL;
        }
        public int Create(Employee employee, Passport passport)
        {
            employee.PassportId = _DAL.InsertPassport(new DbPassport { Number = passport.Number, Type = passport.Type });
            return _DAL.Insert(employee.ToDbEmployee());
        }

        public void Delete(int employeeId)
        {
            _DAL.Delete(employeeId);
        }

        public IEnumerable<Employee> GetAllByCompanyId(int companyId)
        {
            return _DAL.GetAllByCompanyId(companyId).Select(x => x.ToEmployee(
                _DAL.GetPassportById(x.PassportId).ToPassport(), _DAL.GetDepartmentByName(x.DepartmentName).ToDepartament()
                )
            );
        }
        public IEnumerable<Employee> GetAllByDepartamentName(string departamentName)
        {
            return _DAL.GetAllByDepartamentName(departamentName).Select(x => x.ToEmployee(
                _DAL.GetPassportById(x.PassportId).ToPassport(), _DAL.GetDepartmentByName(x.DepartmentName).ToDepartament()
                )
            );
        }

        public void Update(int id, Employee employee)
        {
            employee.Id = id;
            _DAL.Update(employee.ToDbEmployee());
            _DAL.UpdatePassport(employee.Passport.ToDbPassport());
        }
    }
}