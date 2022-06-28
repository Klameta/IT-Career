using System;
using System.Linq;
namespace _11._1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            
            int n = 0;
            int n1 = 0;
            int n2 = 0;


            if (arr.Length % 2 == 0)
            {
                n = arr[arr.Length / 2 - 1];
                n1 = arr[arr.Length / 2];

                Console.WriteLine($"{{ {n}, {n1} }}");
            }
            else if (arr.Length % 2 == 1)
            {
                n = arr[arr.Length / 2 - 1];
                n1 = arr[arr.Length / 2];
                n2 = arr[arr.Length / 2 + 1];
                Console.WriteLine($"{{ {n}, {n1}, {n2} }}");

            }
            else
            {
                n = arr[0];
                Console.WriteLine($"{{ {n} }}");

            }


        }
    }
}
