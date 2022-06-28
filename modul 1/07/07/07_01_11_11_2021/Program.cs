using System;

namespace _07_01_11_11_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            if (age>=16)
            {
                if (type =="m")
                {
                    Console.WriteLine("Mr.");
                }
                else if (type =="f")
                    Console.WriteLine("Ms.");
            }
            else if (age <16)
            {

                if (type == "m")
                {
                    Console.WriteLine("Master");
                }
                else if (type == "f")
                    Console.WriteLine("Miss");
            }
        }
    }
}
