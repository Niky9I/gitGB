using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"(localdb)\MSSQLLocalDB";

            string database = "DB_EmpDep";
           

            return DBSQLServerUtils.GetDBConnection(datasource, database);
        }
    }
}
