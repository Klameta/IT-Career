namespace _02.Combinations
{
    internal class Program
    {
        static int n, k;
        static int[] elements;
        static int[] combinations;
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());

            combinations = new int[k];

            Generate(0, 1);
        }

        private static void Generate(int index, int start)
        {
            if (index == k)
            {
                Console.WriteLine(string.Join(" ", combinations));
                return;
            }

            for (int i = start; i < n; i++)
            {
                combinations[index] = i;    
                Generate(index + 1, i + 1);
            }
        }
    }
}