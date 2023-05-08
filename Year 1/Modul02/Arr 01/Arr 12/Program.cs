using System;
using System.Linq;
namespace Arr_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                .Split(' ')
                .ToArray();

            arr = arr.Reverse().ToArray();

            Console.WriteLine(string.Join(' ', arr));

        }
    }
}
