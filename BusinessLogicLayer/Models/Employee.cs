using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public int CompanyId { get; set; }
        public string DepartmentName { get; set; }
        public int PassportId { get; set; }
        public Departament Department { get; set; }
        public Passport Passport { get; set; }


    }
}
