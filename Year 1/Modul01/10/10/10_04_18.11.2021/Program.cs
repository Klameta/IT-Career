using System;

namespace _10_04_18._11._2021
{
    class Program
    {
        static void Main(string[] args)
        
        {
            int nInput = int.Parse(Console.ReadLine());
            int nPow = 1;
            for (int i = 0; i <= nInput; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(nPow);
                    nPow *= 4;
                }

            }
        }
    }
}
