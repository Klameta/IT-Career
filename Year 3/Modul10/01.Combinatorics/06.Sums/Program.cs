namespace _06.Sums
{
    internal class Program
    {
        static int n;
        static int[] nums;
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            nums = new int[n];

            BreakingSum(n,0);
        }

        private static void BreakingSum(int n, int index)
        {
            if (n==0)
            {
                Console.WriteLine(string.Join("+", nums.Take(index)));
            };
        }
    }
}