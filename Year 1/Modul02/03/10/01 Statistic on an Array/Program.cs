using System;
using System.Linq;

namespace _01_Statistic_on_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int nMin = int.MaxValue;
            int nMax = int.MinValue;
            int sum = 0;
            double avr = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > nMax)
                {
                    nMax = arr[i];
                }

                if (arr[i] <nMin)
                {
                    nMin = arr[i];
                }
                sum += arr[i];
            }
            avr = (double)sum / (arr.Length);

            Console.WriteLine($"Min = {nMin}");
            Console.WriteLine($"Max = {nMax}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {avr:F2}");
        }
    }
}
