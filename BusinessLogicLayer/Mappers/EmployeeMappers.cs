using BusinessLogicLayer.Models;
using DataAccessLayer;
using DataAccessLayer.Classes;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Mappers
{
    internal class EmployeeMappers
    {
        internal static DbEmployee ToDbEmployee(this Employee source)
        {
            return source == null ? default : new DbEmployee
            {
                Id = source.Id,
                PostId = source.PostId,
                ParentId = source.ParentId,
                Nickname = source.Nickname,
                Message = source.Message
            };
        }
        {

        }
    }
}
