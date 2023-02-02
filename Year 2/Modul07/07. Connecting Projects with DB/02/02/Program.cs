using System;
using System.Data.SqlClient;

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conString = @"Data Source = (localdb)\MSSQLLocalDB; Database = SoftUni; Integrated Security = true;";

            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            ;
            using (conn)
            {
                Console.WriteLine("Connection success");
                string query = "SELECT COUNT(*) FROM EMPLOYEES";
                SqlCommand cmd = new SqlCommand(query, conn);
                Console.WriteLine(cmd.ExecuteScalar());

                query = "select * From Employees";
                cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader[0]}: {reader[1]} {reader[2]} {reader[8]:f2}");
                    }
                }
            }
        }
    }
}
