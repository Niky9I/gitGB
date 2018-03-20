using Lesson7;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace WpfApp2
{
    class GetData
    {

        public static void GetDataEmp()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                QueryEmployee(conn);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                // Закрыть соединение.
                conn.Close();
                // Разрушить объект, освободить ресурс.
                conn.Dispose();
            }
            Console.Read();
        }

        private static void QueryEmployee(SqlConnection conn)
        {
            string sql = "SELECT * FROM TableEmp";

            // Создать объект Command.
            SqlCommand cmd = new SqlCommand();

            // Сочетать Command с Connection.
            cmd.Connection = conn;
            cmd.CommandText = sql;


            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        // Индекс столбца Emp_ID в команде SQL.
                        int empId = (int)(reader.GetValue(0));
                                               
                        string empName = reader.GetString(1);
                                              
                        string empAge = reader.GetString(2);

                        string empSalary = reader.GetString(3);

                        string empEmpDep = null;

                        if (!reader.IsDBNull(4))
                        {
                            empEmpDep = reader.GetString(4);
                        }


                        
                        //Model.items.Add(new Employee() { Id = empId, NameEmp = empName, Age = empAge, Salary = empSalary, Dep = empEmpDep });

                    }
                }
            }
        }
    }
}
    