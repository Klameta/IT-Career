using System;

namespace _10_01_18._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int nInput = int.Parse(Console.ReadLine());
            for (int i = 1; i <= nInput; i+=3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
