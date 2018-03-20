using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class DBSQLServerUtils
    {
        public static SqlConnection GetDBConnection(string datasource, string database)
        {
            
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Integrated Security = True;";

            SqlConnection conn = new SqlConnection(connString);

            return conn;
        }
    }
}
