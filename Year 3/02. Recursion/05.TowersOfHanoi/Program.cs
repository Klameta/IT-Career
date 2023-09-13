namespace _05.TowersOfHanoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = 1; int b = 2; int c = 3;

            Hanoi(n, a, b, c);
        }

        private static void Hanoi(int n, int a, int b, int c)
        {
            if (n == 0) return;

            Hanoi(n-1, a, b, c);
            Console.WriteLine($"{a} -> {c}");
            Hanoi(n, a, b, c);
        }
    }
}