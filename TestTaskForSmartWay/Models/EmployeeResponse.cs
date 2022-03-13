using BusinessLogicLayer.Models;

namespace TestTaskForSmartWay.Models
{
    public class EmployeeResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public int CompanyId { get; set; }
        public Departament Department { get; set; }
        public Passport Passport { get; set; }
    }
}
