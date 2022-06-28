using System;
using System.Linq;
namespace Arr_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum, min, max;
            int[] arr;
            AssigningValues(out sum, out min, out max, out arr);

            FindingSumMaxMin(ref sum, ref min, ref max, arr);

            Output(sum, min, max);
        }

        private static void Output(int sum, int min, int max)
        {
            Console.WriteLine($"Min = {min} Max = {max} Sum = {sum}");
        }

        private static void AssigningValues(out int sum, out int min, out int max, out int[] arr)
        {
            int n = int.Parse(Console.ReadLine());
            sum = 0;
            min = int.MaxValue;
            max = int.MinValue;
             arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        private static void FindingSumMaxMin(ref int sum, ref int min, ref int max, int[] arr)
        {
            foreach (var item in arr)
            {
                sum += item;
            }


            foreach (var item in arr)
            {
                if (item < min)
                {
                    min = item;
                }
            }

            foreach (var item in arr)
            {
                if (item > max)
                {
                    max = item;
                }
            }
        }
    }
}
