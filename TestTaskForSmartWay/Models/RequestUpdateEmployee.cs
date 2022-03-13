using BusinessLogicLayer.Models;

namespace TestTaskForSmartWay.Models
{
    public class RequestUpdateEmployee
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Phone { get; set; }
        public int? CompanyId { get; set; }
        public string? DepartmentName { get; set; }
        public Passport? Passport { get; set; }
    }
}
