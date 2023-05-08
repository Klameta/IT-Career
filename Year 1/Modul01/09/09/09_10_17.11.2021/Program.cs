using System;

namespace _09_10_17._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int nInput = int.Parse(Console.ReadLine());
            int sumMax = int.MinValue;
            int sum=0;
            for (int i = 0; i < nInput; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n >sumMax)
                {
                    sumMax = n;
                }                
                    sum += n;
            }
            sum = Math.Abs(sumMax -( sum - sumMax));
            if (sum == 0)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumMax}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {sum}");
            }
        }
    }
}
