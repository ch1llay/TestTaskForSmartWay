using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class DbPassport
    {
        public string Type { get; set; }
        public string Number { get; set; }

        public global::BusinessLogicLayer.Models.Passport ToPassport()
        {
            throw new NotImplementedException();
        }
    }
}
