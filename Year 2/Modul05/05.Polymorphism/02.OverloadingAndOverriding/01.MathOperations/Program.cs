using System;

namespace _01.MathOperations
{
    class Program
    {
        public static void Main()
        {
            MathoOperations mo = new MathoOperations();
            Console.WriteLine(mo.Add(2, 3));
            Console.WriteLine(mo.Add(2.2, 3.3, 5.5));
            Console.WriteLine(mo.Add(2.2m, 3.3m, 4.4m));
        }
    }
}
