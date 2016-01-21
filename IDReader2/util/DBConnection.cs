using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDReader2.util
{
    class DBConnection
    {
        public static SqlConnection getConnection()
        {
            string conStr = System.Configuration.ConfigurationManager.ConnectionStrings["sqlStr"].ConnectionString;
            Console.WriteLine("连接语句" + conStr);
            return new SqlConnection(conStr);
        }
        public static void closeConnection(SqlConnection con)
        {
            if (con != null)
            {
                con.Close();
            }
        }
    }
}
