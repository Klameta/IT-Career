namespace _01.Permutations
{
    internal class Program
    {
        static int n;
        static int[] permutations;
        static int[] elements;
        static void Main(string[] args)
        {
            int index = int.Parse(Console.ReadLine());

            Generte(index);
        }

        private static void Generte(int index)
        {
            if (index == 0)
            {
                Console.WriteLine(string.Join(" ", permutations));
                    return;
            }

            for (int i = 0; i < n; i++)
            {
                if (!used = true)
                {
                    used[i] = true;
                    permutations[index] = ;

                }
            }
        }
    }
}