using System;
using System.Linq;

namespace Arr_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(string.Join(' ', arr));
            Console.WriteLine(string.Join(' ',arr.Reverse()));
        }
    }
}
