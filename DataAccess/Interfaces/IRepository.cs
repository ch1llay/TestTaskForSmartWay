using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    internal interface IRepository
    {
        T Insert<T> (T entity);
        T Update<T> (T entity);
        IEnumerable<T> GetAll<T>();



    }
}
