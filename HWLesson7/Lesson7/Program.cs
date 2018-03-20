using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
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
                string sql = "SELECT Id, NameEmp, Age, Salary, EmpDep FROM TableEmp";

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
                            int empIdIndex = reader.GetOrdinal("Id"); // 0
                            int empId = (int)(reader.GetValue(0));

                                              
                            int empNameIndex = reader.GetOrdinal("NameEmp");// 1
                            string empName = reader.GetString(empNameIndex);

                            int empAgeIndex = reader.GetOrdinal("Age"); // 2
                            string empAge = reader.GetString(empAgeIndex);
                         
                            int empSalaryIndex = reader.GetOrdinal("Salary"); // 3
                            string empSalary = reader.GetString(empSalaryIndex);
                            
                            int empEmpDepIndex = reader.GetOrdinal("EmpDep");// 4
                            string empEmpDep = null;

                            if (!reader.IsDBNull(empEmpDepIndex))
                            {
                            empEmpDep = reader.GetString(empEmpDepIndex);
                            }
                            Console.WriteLine("--------------------");
                            Console.WriteLine("EmpId:" + empId);
                            Console.WriteLine("EmpName:" + empName);
                            Console.WriteLine("Age:" + empAge);
                            Console.WriteLine("Salary:" + empSalary);
                            Console.WriteLine("EmpDep:" + empEmpDep);
                    }
                    }
                }

            }


            //    using (SqlConnection connection = new SqlConnection(connectionString))
            //    {
            //        connection.Open();
            //        try
            //        {
            //            SqlCommand command = new SqlCommand(createExpression, connection); int number = command.ExecuteNonQuery();
            //            command = new SqlCommand(createStoredProc, connection); number = command.ExecuteNonQuery(); Console.WriteLine(number);
            //            command = new SqlCommand(sqlExpression, connection); number = command.ExecuteNonQuery(); Console.WriteLine(number);
            //        }
            //        catch (System.Data.SqlClient.SqlException) { }


            //        Console.ReadKey();
            //    }
            //}
            //public static string createExpression = @" CREATE  TABLE[dbo].[People] (                                      
            //        [Id]  INT IDENTITY(1,1) NOT NULL,
            //        [FIO]    NVARCHAR(20) NOT NULL,
            //        [Birthday]        NVARCHAR(10)  NOT NULL,
            //        [Email]      NCHAR(20)  NOT NULL,
            //        [Phone]      NVARCHAR(12)   NULL,
            //        CONSTRAINT[PK_dbo.People]   PRIMARY  KEY  CLUSTERED( [Id] ASC)                                 
            //        ) ;";
            //public static string createStoredProc = @" CREATE  PROCEDURE [dbo].[sp_GetPeople]  AS  SELECT *   FROM People;";
            //public static string sqlExpression = @"INSERT INTO  People (EmpName, Age, Salary)  VALUES ('Ivanov  Ivan', '18.10.2001', '30000') ;                                      
            //INSERT INTO  People(  FIO,   Birthday,   Email,   Phone)   VALUES( ' Петров  Петр Петрович',  ' 15.01.2001',  ' somebody@mail.com',  ' 8916555555') ";



        }

    }
