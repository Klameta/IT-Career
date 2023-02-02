using System;
using System.Data.SqlClient;

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string con = @"Server = (localdb)\MSSQLLocalDB; DATABASE = MinionsDB; Integrated Security = true";
            SqlConnection conn = new SqlConnection(con);
            conn.Open();
            using (conn)
            {
                string query =
                    "\r\nselect v.Name, Count(*) as Count\r\nfrom Villains as v\r\n         join MinionsVillains\r\n              on v.Id = MinionsVillains.VillainId\r\n         join Minions as m\r\n              on m.Id = MinionId\r\ngroup by v.Name\r\nhaving count(*) >=2;\r\n";
                SqlCommand cmd = new SqlCommand(query,conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"{reader[0]} - {reader[1]}");
                }
                reader.Close();
            }
        }
    }
}
