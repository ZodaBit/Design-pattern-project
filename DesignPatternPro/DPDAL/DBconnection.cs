using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DPDAL
{
     class DBconnection
    {
         public static string connectionString = "Data Source=BEP-W541;Initial Catalog=northwind;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(connectionString);
    }
}
