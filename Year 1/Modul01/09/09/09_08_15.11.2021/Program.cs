using System;

namespace _09_08_15._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputN = int.Parse(Console.ReadLine());
            int sumEven= 0;
            int sumOdd = 0;
            for (int i = 0; i < inputN; i++)
            {
                if (i % 2 == 0)
                {
                    int nEven = int.Parse(Console.ReadLine());
                    sumEven += nEven;

                }
                else
                {
                    int nOdd = int.Parse(Console.ReadLine());
                    sumOdd += nOdd;
                }
            }
            if (Math.Abs(sumOdd-sumEven)==0)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {sumEven}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sumOdd-sumEven)}");
            }
        }
    }
}
