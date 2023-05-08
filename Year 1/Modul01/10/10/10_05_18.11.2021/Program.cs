using System;

namespace _10_05_18._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int nInput = int.Parse(Console.ReadLine());
            int nPow = 1;
            for (int i = 1; i <= nInput; )
            {
                Console.WriteLine(i);
                i = 2*i +1;


            }
        }
    }
}
