using System;
using System.Data.SqlClient;

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string con = @"Server = (localdb)\MSSQLLocalDB; Integrated Security = true;";
            SqlConnection conn = new SqlConnection(con);
            conn.Open();
            using (conn)
            {
                string query = "create database DemoSQL";
                /*SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Demo has been created");*/
                query =
                "use DemoSQL \r\ncreate table MyTable\r\n(\r\n    Id int PRIMARY KEY ,\r\n    FirstName varchar(50) not null ,\r\n    LastName varchar(50) not null ,\r\n    Age int not null,\r\n)";

                    SqlCommand command = new SqlCommand(query, conn);
                    command.ExecuteNonQuery();
                    Console.WriteLine("table has been created");
            }

        }
    }
}
