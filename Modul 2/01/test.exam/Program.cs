using System;
using System.Linq;

namespace test.exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                int length = int.Parse(Console.ReadLine());
                float width = float.Parse(Console.ReadLine());
                int wingSpan = int.Parse(Console.ReadLine());

                float age = (length * length) * (width + 2 * wingSpan);
                    Console.WriteLine(age);
            }
            

        }
    }
}
