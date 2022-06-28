using System;

namespace _05_08_07._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = double.Parse(Console.ReadLine());
            var num2 = double.Parse(Console.ReadLine());
            var num3 = double.Parse(Console.ReadLine());
            double num12;
            double num23;
            if (num1 == num2)
            {
                num12 = num1;


                if (num12 == num3)
                {
                    Console.WriteLine("yes");
                }

            }
            else if (num2 == num3)
            {
                num23 = num3;


                if (num23 == num1)
                {
                    Console.WriteLine("yes");
                }
            }



            if (num1 != num2)
            {
                Console.WriteLine("no");

            }
            else if (num2 != num3)
            {
                Console.WriteLine("no");
            }
            else if (num1 != num3)
                Console.WriteLine("no");


        }
    }
}
