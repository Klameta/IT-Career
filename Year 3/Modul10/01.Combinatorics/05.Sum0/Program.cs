namespace _05.Sum0
{
    internal class Program
    {
        static int[] numbers;
        static int[] variation;
        static int k;
        static void Main(string[] args)
        {
            k = int.Parse(Console.ReadLine());
            numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            variation = new int[k];

            Generate(0);
        }
        private static void Generate(int index)
        {
            if (index == k)
            {
                Print();
                return;
            }
            for (int i = 0; i < 2; i++)
            {
                variation[index] = i;
                Generate(index + 1);
            }
        }

        private static void Print()
        {
            int sum = 0;
            for (int i = 0; i < k; i++)
            {
                if (variation[i] == 0)
                {
                    sum += numbers[i];
                }
                else
                {
                    sum -= numbers[i];
                }
            }

            if (sum == 0)
            {
                for (int i = 0; i < k; i++)
                {
                    if (variation[i] == 0)
                    {
                        Console.Write($"+{numbers[i]} ");
                    }
                    else
                    {
                        Console.Write($"-{numbers[i]} ");
                    }
                }
                    Console.Write("= 0");
                    Console.WriteLine();
            }

        }
    }
}