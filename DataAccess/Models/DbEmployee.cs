using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal class DbEmployee
    {
        int Id { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        string Phone { get; set; }
        int CompanyId { get; set; }
    }
}
