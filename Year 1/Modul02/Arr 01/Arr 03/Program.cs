using System;
using System.Linq;

namespace Arr_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr;
            int x, less, more, are;
            AssignValues(out arr, out x, out less, out more, out are);

            FindingLessEqualsMore(arr, x, ref less, ref more, ref are);

            Output(less, more, are);

        }

        private static void Output(int less, int more, int are)
        {
            Console.WriteLine($"Less than x = {less}");
            Console.WriteLine($"More than x = {more}");
            Console.WriteLine($"Equals x = {are}");
        }

        private static void FindingLessEqualsMore(int[] arr, int x, ref int less, ref int more, ref int are)
        {
            foreach (var item in arr)
            {
                if (item < x)
                {
                    less++;
                }
            }

            foreach (var item in arr)
            {
                if (item > x)
                {
                    more++;
                }
            }

            foreach (var item in arr)
            {
                if (item == x)
                {
                    are++;
                }
            }
        }

        private static void AssignValues(out int[] arr, out int x, out int less, out int more, out int are)
        {
            int n = int.Parse(Console.ReadLine());

            arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            x = int.Parse(Console.ReadLine());
            less = 0;
            more = 0;
            are = 0;
        }
    }
}
