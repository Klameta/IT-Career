using System;

namespace _09_04_14._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int mainNum = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < mainNum; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}
