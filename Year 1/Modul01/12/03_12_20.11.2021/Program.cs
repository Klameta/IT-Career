using System;

namespace _03_12_20._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int nInput = int.Parse(Console.ReadLine());
            int ndiv = 2;
            if (nInput<2)
            {
                Console.WriteLine("Not Prime");
            }
            for (int i = 1; i <= nInput; i++)
            {
                if ((nInput % i == 0) || (i!=nInput))
                {
                    Console.WriteLine("Not Prime");
                }
                
            }
            {

            }
        }
    }
}
