using System;

namespace _09_05_15._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputN = int.Parse(Console.ReadLine());
            int MinN = int.MaxValue;
            for (int i = 0; i < inputN; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < MinN)
                {
                    MinN = num;
                }
            }
            Console.WriteLine(MinN);
        }
    }
}
