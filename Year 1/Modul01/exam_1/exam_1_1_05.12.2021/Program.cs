using System;

namespace exam_1_1_05._12._2021
{
    class Program
    {
        static void Main(string[] args)
        
        {
            double cubeLaminat = double.Parse(Console.ReadLine());
            double widthRoom = double.Parse(Console.ReadLine());
            double lenghtRoom = double.Parse(Console.ReadLine());
            double cubePrice = double.Parse(Console.ReadLine());


            double P = widthRoom * lenghtRoom;
            double lPrice = cubeLaminat * P;
            double pPrice = P * cubePrice;
            double montazP = 0.4 * (lPrice + pPrice);
            double sum = lPrice + pPrice + montazP;
            Console.WriteLine($"{sum:F2}");
        }
    }
}
