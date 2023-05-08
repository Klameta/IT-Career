using System;
using System.Linq;

namespace Arr_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr;
            int counter;
            AssignValues(out arr, out counter);

            counter = CountingNumbersBetween10And100(arr, counter);

            OutputSortAndReverse(arr, counter);
        }

        private static void OutputSortAndReverse(int[] arr, int counter)
        {
            Array.Sort(arr);

            Console.WriteLine(string.Join(' ', arr));

            Array.Reverse(arr);

            Console.WriteLine(string.Join(' ', arr));
            Console.WriteLine(counter);
        }

        private static int CountingNumbersBetween10And100(int[] arr, int counter)
        {
            foreach (var item in arr)
            {
                if (item >= 10 && item <= 100)
                {
                    counter++;
                }
            }

            return counter;
        }

        private static void AssignValues(out int[] arr, out int counter)
        {
            int n = int.Parse(Console.ReadLine());
            arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            counter = 0;
        }
    }
}
