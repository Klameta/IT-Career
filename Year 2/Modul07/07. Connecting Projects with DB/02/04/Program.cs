using System;
using System.Data.SqlClient;

namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string con = @"Server = (localdb)\MSSQLLocalDB; Database = DemoSQL; Integrated Security = true";
            SqlConnection connection = new SqlConnection(con);
            connection.Open();

            using (connection)
            {
                string query =
                    "\r\ninsert into MyTable values\r\n                        (1, 'Pesho','Peshov', 15),\r\n                        (2, 'Pesho','Peshov', 15),\r\n                        (3, 'Pesho','Peshov', 15),\r\n                        (4, 'Pesho','Peshov', 15)\r\n                        ";
                SqlCommand cmd = new SqlCommand(query,connection);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
