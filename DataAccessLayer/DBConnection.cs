using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DBConnection
    {
        public static NpgsqlConnection CreateConnection()
        {
            return new NpgsqlConnection("User ID = postgres; password = password; host = localhost; port = 5432; database = TestTask; ");
        }
    }
}
