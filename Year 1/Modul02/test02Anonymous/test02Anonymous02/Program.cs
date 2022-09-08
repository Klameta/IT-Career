using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Numerics;

namespace test02Anonymous02
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine().Split(' ').ToList();
            
            var mOrD = Console.ReadLine().Split(' ').ToList();

            while (mOrD[0] != "3:1")
            {
                if (mOrD[0]== "merge")
                {
                    command.Remove(" ");

                }
                else
                {

                }
                mOrD = Console.ReadLine().Split(' ').ToList();
            }
            Console.WriteLine(string.Join(' ',command));
        }
    }
}
