using System;

namespace _10_03_18._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int nInput = int.Parse(Console.ReadLine());
            int nPow = 1;
            for (int i = 0; i <= nInput; i++)
            {
                Console.WriteLine(nPow);
                nPow *= 2;
                
                
            }
            
        }
    }
}
