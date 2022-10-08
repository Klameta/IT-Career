using System;

namespace _00.DemoPartTwo
{
    internal class Program
    {
        delegate int myDelegate(int a, int b);
        static void Main(string[] args)
        {
            myDelegate ab = (a, b) => a + b;
            int result = ab(1, 1);
            Console.WriteLine(result);

            myDelegate s = sum;
            Console.WriteLine();

            myDelegate d = new myDelegate(sum);
            Console.WriteLine(d(4,5));

            myDelegate ab1 = (a,b) => a - b;
            Console.WriteLine(ab1(3,2));

        }

        static int sum(int a, int b)
        {
            return a + b;
        }
    }
}
