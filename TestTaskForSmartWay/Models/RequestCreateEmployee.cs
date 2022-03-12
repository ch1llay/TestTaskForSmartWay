using BusinessLogicLayer.Models;
using System.ComponentModel.DataAnnotations;

namespace TestTaskForSmartWay.Models
{
    public class RequestCreateEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public int CompanyId { get; set; }
        public string DepartmentName { get; set; }
        public Passport Passport { get; set; }


    }
}
