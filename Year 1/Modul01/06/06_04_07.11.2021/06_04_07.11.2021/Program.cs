using System;

namespace _06_04_07._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var mer1 = Console.ReadLine();
            var mer2 = Console.ReadLine();
            double num2 = 0;
            double num3 =0;
            if (mer1 == "m")
            {
                num2 = num;
            }
            else if (mer1 == "mm")
            {
                num2 = num/ 1000;
            }
            else if (mer1 == "cm")
            {
                num2 =num/100;
            }
            else if (mer1 == "mi")
            {
                num2 = num/ 0.000621371192;
            }
            else if (mer1 == "in")
            {
                num2 = num/ 39.3700787;
            }
            else if (mer1 == "km")
            {
                num2 = num / 0.001;
            }
            else if (mer1 == "ft")
            {
                num2 = num / 3.2808399;
            }
            else if (mer1 == "yd")
            {
                num2 = num / 1.0936133;
            }

            if (mer2 == "m")
            {
                num3 = num2 * num;
            }
            else if (mer2 == "mm")
            {
                num3 = num2 * 1000;
            }
            else if (mer2 == "cm")
            {
                num3 = num2 * 100;
            }
            else if (mer2 == "mi")
            {
                num3 = num2* 0.000621371192;
            }
            else if (mer2 == "in")
            {
                num3 = num2* 39.3700787;
            }
            else if (mer2 == "km")
            {
                num3 = num2* 0.001;
            }
            else if (mer2 == "ft")
            {
                num3 = num2* 3.2808399;
            }
            else if (mer2 == "yd")
            {
                num3 = num2* 1.0936133;
            }
            Console.WriteLine(value: $"{num3} {mer2}");
        }
    }
}
