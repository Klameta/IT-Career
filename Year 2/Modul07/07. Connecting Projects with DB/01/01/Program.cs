using System;
using System.Data.SqlClient;

namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string con = @"Server = (localdb)\MSSQLLocalDB; DATABASE = MinionsDB; Integrated Security= true";

           SqlConnection conn = new SqlConnection(con);
           conn.Open();

           using (conn)
           {
               /*string query = "\r\ncreate database MinionsDB";*/
               /*string query =
                   "\r\ncreate table Countries\r\n(\r\n    Id int identity PRIMARY KEY,\r\n    Name varchar(50) not null\r\n);\r\n\r\ncreate table Towns\r\n(\r\n    Id int identity primary key ,\r\n    Name varchar(50) not null,\r\n    CountryCode int foreign key references Countries(Id) not null\r\n);\r\n\r\ncreate table EvilFactors\r\n(\r\n    Id int identity primary key ,\r\n    Name varchar(50) not null\r\n);\r\n\r\ncreate  table Villains\r\n(\r\n    Id int identity primary key ,\r\n    Name varchar(50) not null ,\r\n    EvilnessFactor int not null foreign key references EvilFactors(Id)\r\n);\r\n\r\ncreate table Minions\r\n(\r\n    Id int identity primary key ,\r\n    Name varchar(50) not null,\r\n    Age int not null,\r\n    TownId int not null foreign key references Towns(Id)\r\n);\r\ncreate table MinionsVillains\r\n(\r\n    MinionId int not null ,\r\n    VillainId int not null ,\r\n    constraint PK_MV primary key (MinionId,VillainId)\r\n);";
*/
              /* string query =
                   "\r\ninsert into EvilFactors values\r\n                            ('very good'),\r\n                            ('good'),\r\n                            ('bad'),\r\n                            ('evil'),\r\n                            ('super evil');\r\ninsert into Countries values\r\n                          ('England'),\r\n                          ('USA'),\r\n                          ('Bulgaria'),\r\n                          ('Germany'),\r\n                          ('Sweden');\r\ninsert into Towns values\r\n                      ('London',1),\r\n                      ('Hasko',3),\r\n                      ('New York', 2),\r\n                      ('Plovdiv', 3),\r\n                      ('Munch', 4);\r\ninsert into Minions\r\nvalues ('Peter', 34, 2),\r\n       ('Dimitrichko', 33, 4),\r\n       ('John', 22, 3),\r\n       ('Shawn', 12, 1),\r\n       ('Gross', 54, 5);\r\n\r\ninsert into Villains\r\nvalues ('George',3),\r\n       ('Fawn', 1),\r\n       ('Arthur', 5),\r\n       ('Merlin', 2),\r\n       ('Gwaine', 4);\r\n\r\ninsert into MinionsVillains\r\nvalues (1,4),\r\n       (4,5),\r\n       (1,1),\r\n       (3,5),\r\n       (4,2);";
              */
              string query = ""
              
              SqlCommand cmd = new SqlCommand(query,conn);
               cmd.ExecuteNonQuery();
           }
        }
    }
}
