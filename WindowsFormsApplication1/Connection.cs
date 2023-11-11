using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    internal class Connection
    {
        private static string stringConnection = @"Data Source=.;Initial Catalog=CauLacBo;Integrated Security=True";
        public static  SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
