using System;

namespace _12_02_19._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int nInput = int.Parse(Console.ReadLine());
            int sum = 1;
            int sFinal = 0;
            while (nInput != 0)
            {
                sum = nInput % 10;
                sFinal += sum;
                nInput /= 10;
            }
            Console.WriteLine(sFinal);
        }
    }
}
