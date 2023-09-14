namespace _04.Pascal
{
    internal class Program
    {

        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            for (long i = 0; i <= n; i++)
            {
                for (long j = 0; j < i; j++)
                {
                    Console.Write(Binome(i, j) + " ");

                }
                Console.Write(1);
                Console.WriteLine();
            }
        }

        private static long Binome(long n, long i)
        {
            if (n == i || i == 0)
            {
                return 1;
            }
            return Binome(n - 1, i) + Binome(n - 1, i - 1);
        }

    }
}