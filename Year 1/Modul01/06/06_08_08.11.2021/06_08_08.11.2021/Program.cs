using System;

namespace _06_08_08._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int ed = num % 10;
            int des = num % 100 / 10;
            string ed2 = "";
            string des2 ="";

            if (ed == 1) ed2 = "one";
            else if (ed == 2) ed2 = "two";
            else if (ed == 3) ed2 = "three";
            else if (ed == 4) ed2 = "four";
            else if (ed == 5) ed2 = "five";
            else if (ed == 6) ed2 = "six";
            else if (ed == 7) ed2 = "seven";
            else if (ed == 8) ed2 = "eight";
            else if (ed == 9) ed2 = "nine";
            if (des == 1) des2 = "teen";
            else if (des == 2) des2 = "twenty";
            else if (des == 3) des2 = "thirty";
            else if (des == 4) des2 = "fourty";
            else if (des == 5) des2 = "fifty";
            else if (des == 6) des2 = "sixty";
            else if (des == 7) des2 = "seventy";
            else if (des == 8) des2 = "eighty";
            else if (des == 9) des2 = "ninety";
            if (num == 10)
            {
                Console.WriteLine("ten");
                return;
            }
            else if (num == 11)
            {
                Console.WriteLine("eleven");
                return;
            }
            else if (num ==12)
            {
                Console.WriteLine("twelve");
                return;
            }
            else if (num == 13)
            {
                Console.WriteLine("thirteen");
                return;
            }
            Console.WriteLine($"{des2} {ed2}");
        }
    }
}
