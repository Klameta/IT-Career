using System;
using System.Linq;
using System.Collections.Generic;
namespace test_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "Blaze it!")
            {
                var teamMates = command.Split(' ', '=','>').ToArray();

                Dictionary<string, string> dic = new Dictionary<string, string>();

                dic.Add(command[0], command[1] ) ;



                Console.WriteLine(string.Join(',', dic));
                command = Console.ReadLine();
            }

           
        }
    }
}
