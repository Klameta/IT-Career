using System;
using System.Data.SqlClient;

namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string con = @"Server = (localdb)\MSSQLLocalDB; Database = SoftUni; Integrated Security = true";
            SqlConnection conn = new SqlConnection(con);
            conn.Open();

            using (conn)
            {
                
            }
        }
    }
}
