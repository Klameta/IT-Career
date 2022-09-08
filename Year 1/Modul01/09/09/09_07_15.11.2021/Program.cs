using System;

namespace _09_07_15._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputN = int.Parse(Console.ReadLine());
            int sInputN = inputN;
            long fSum = 0;
            long sSum = 0;

            for (int i = 0; i < inputN; i++)
            {
                long fNum = long.Parse(Console.ReadLine());
                fSum += fNum;
            }
            for (int i = 0; i < sInputN; i++)
            {
                long sNum = long.Parse(Console.ReadLine());
                sSum += sNum;
            }
            if (sSum==fSum)
            {
                Console.WriteLine($"Yes, sum = {sSum}");
            }
            else
            {
                long diff = Math.Abs(sSum - fSum);
                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}
