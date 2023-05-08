using System;
using System.Linq;

namespace Arr_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr;
            int max, min, sum;
            double avr;
            AssignValues(out arr, out max, out min, out avr, out sum);

            avr = FindingMaxMinSumAndAverage(arr, ref max, ref min, ref sum);

            Output(max, min, sum, avr);

        }

        private static void Output(int max, int min, int sum, double avr)
        {
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {avr}");
        }

        private static double FindingMaxMinSumAndAverage(int[] arr, ref int max, ref int min, ref int sum)
        {
            double avr;
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

            foreach (var item in arr)
            {
                sum += item;
            }

            avr = (double)sum / arr.Length;
            return avr;
        }

        private static void AssignValues(out int[] arr, out int max, out int min, out double avr, out int sum)
        {
            arr = Console.ReadLine()
                 .Split(' ')
                 .Select(int.Parse)
                 .ToArray();
            max = int.MinValue;
            min = int.MaxValue;
            avr = 0;
            sum = 0;
        }
    }
}
