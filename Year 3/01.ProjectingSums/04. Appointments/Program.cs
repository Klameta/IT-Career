namespace _04._Appointments
{
    internal class Program
    {
        static int sum;
        static int maxSum = int.MinValue;
        static int minSum = int.MaxValue;
        static int nEmployees;
        static int[,] prices;
        static bool[] taken;
        static void Main(string[] args)
        {
            nEmployees = int.Parse(Console.ReadLine());
            prices = new int[nEmployees, nEmployees];
            taken = new bool[nEmployees];

            for (int i = 0; i < nEmployees; i++)
            {
                int[] line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int j = 0; j < nEmployees; j++)
                {
                    prices[i, j] = line[j];
                }
            }

            Calculate(0);
        }

        private static void Calculate(int position)
        {
            if (position == nEmployees)
            {
                if (sum < minSum) minSum = sum;
                return;
            }
            for (int i = 0; i < nEmployees; i++)
            {
                if (!taken[i])
                {
                    taken[i] = true;
                    sum += prices[position, i];

                    Calculate(position + 1);

                    taken[i] = false;
                    sum -= prices[position, i];
                }
            }

        }
    }
}