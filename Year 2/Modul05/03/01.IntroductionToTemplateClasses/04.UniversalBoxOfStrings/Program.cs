using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.UniversalBoxOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();
            for (int i = 0; i < count; i++)
            {
                box.Add(Console.ReadLine());
            }

            Console.WriteLine(box);
        }
    }
}
