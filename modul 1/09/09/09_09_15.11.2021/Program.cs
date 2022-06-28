using System;

namespace _09_09_15._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int nInput = int.Parse(Console.ReadLine());
            int diff = 0;
            int maxDiff = int.MinValue;
            int n1_2 = 0;

            for (int i = 0; i < nInput; i++)
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                n1_2 = n1 + n2;
                if (n1_2 !=diff)
                {
                    diff = n1_2;
                    if (diff>maxDiff)
                    {
                        diff = maxDiff;
                    }
                }
            }
            if (n1_2 == maxDiff)
            {
                Console.WriteLine("yes");
            }
            else
                Console.WriteLine("no");

        }
    }
}
