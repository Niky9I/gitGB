using Lesson7;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    class AddEmpToDB
    {
        public static void AddEmp()
        {
            SqlConnection connection = DBUtils.GetDBConnection();
            connection.Open();
            try
            {
                // Команда Insert.
                string sql = "Insert into TableEmp (NameEmp, Age, Salary) "
                                                 + " values (@NameEmp, @Age, @Salary) ";

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql;

                // Создать объект Parameter.
                SqlParameter nameParam = new SqlParameter("@NameEmp", SqlDbType.NVarChar);
                nameParam.Value = "Sergey";
                cmd.Parameters.Add(nameParam);

                // Добавить параметр @highSalary (Написать короче).
                SqlParameter ageParam = cmd.Parameters.Add("@Age", SqlDbType.NVarChar);
                ageParam.Value = 20;

                // Добавить параметр @lowSalary (Написать короче).
                cmd.Parameters.Add("@Salary", SqlDbType.NVarChar).Value = 10000;

               // Model.items.Add(new Employee() { NameEmp = nameParam.Value, Age = empAge, Salary = empSalary, Dep = empEmpDep });

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                connection.Close();
                connection.Dispose();
                connection = null;
            }

            Console.Read();

        }

    }
}
