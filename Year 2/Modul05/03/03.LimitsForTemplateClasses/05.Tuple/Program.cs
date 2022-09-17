using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nameAdress = Console.ReadLine().Split();
            string name = nameAdress[0] + " " + nameAdress[1];
            string adress = nameAdress[2];
            Tuple1<string, string> nameAdressTuple = new Tuple1<string, string>(name, adress);
            Console.WriteLine(nameAdressTuple);

            string[] nameLiter = Console.ReadLine().Split();
            Tuple1<string, int> beer = new Tuple1<string, int>(nameLiter[0], int.Parse(nameLiter[1]));
            Console.WriteLine(beer);

            string[] intdouble = Console.ReadLine().Split();
            Tuple1<int, double> nums = new Tuple1<int, double>(int.Parse(intdouble[0]), double.Parse(intdouble[1]));
            Console.WriteLine(nums);
        }
    }
}
