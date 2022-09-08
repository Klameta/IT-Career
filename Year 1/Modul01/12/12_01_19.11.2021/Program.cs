using System;

namespace _12_01_19._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int nInput = int.Parse(Console.ReadLine());
            int sum=1;
            for (int i = 1; i <= nInput; i++)
            {
                sum *= i;
                
            }
            Console.WriteLine(sum);
        }
    }
}
