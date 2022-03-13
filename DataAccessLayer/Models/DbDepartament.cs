using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class DbDepartament
    {
        [Key]
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}
