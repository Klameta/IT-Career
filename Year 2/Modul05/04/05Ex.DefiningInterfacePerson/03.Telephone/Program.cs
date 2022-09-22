using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Telephone
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split().ToList();
            List<string> sites = Console.ReadLine().Split().ToList();

            SmartPhone smart = new SmartPhone(numbers, sites);
            smart.Call();
            smart.Browsing();
        }
    }
}
