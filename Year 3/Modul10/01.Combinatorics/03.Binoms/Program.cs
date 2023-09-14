namespace _03.Binoms
{
    internal class Program
    {
        static int n;
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                Console.Write(Binome(n, i) + " ");
            }
        }

        private static int Binome(int n, int i)
        {
            if (n==i || i==0)
            {
                return 1;
            }
            return Binome(n-1, i) + Binome(n-1, i-1);
        }
    }
}