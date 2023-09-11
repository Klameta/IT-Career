namespace _01.ProjectingSums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int finalSum = 18;
            int[] coins = new int[] { 10, 10, 5, 5, 2, 2, 1, 1 };

            if (!ProjectingSums(finalSum, coins))
            {
                Console.WriteLine("Sum hs not been found");
            };
        }

        private static bool ProjectingSums(int finalSum, int[] coins)
        {
            int currSum = 0;
            Queue<int> resultCoins = new Queue<int>();
            for (int i = 0; i < coins.Length; i++)
            {
                int currCoin = coins[i];
                if (currSum + currCoin > finalSum) continue;

                currSum += currCoin;
                resultCoins.Enqueue(currCoin);

                if (currSum == finalSum)
                {
                    Console.WriteLine("Sum has been found");
                    return true;
                }
            }
            return false;
        }
    }
}