namespace _01._Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ulong input = ulong.Parse(Console.ReadLine());

            Console.WriteLine(Fiboncci(input));
        }

        public static ulong Fiboncci(ulong n)
        {
            if (n <= 2)
            {
                return 1;
            }
            return Fiboncci(n - 1) + Fiboncci(n - 2);
        }
    }
}