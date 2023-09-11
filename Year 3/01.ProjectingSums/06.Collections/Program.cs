namespace _06.Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> galaxy = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            int nCollections = int.Parse(Console.ReadLine());

            List<List<int>> subsets = new List<List<int>>();
            for (int i = 0; i < nCollections; i++)
            {
                subsets.Add(Console.ReadLine().Split(", ").Select(int.Parse).ToList());
            }

            subsets = subsets.OrderByDescending(x => x.Count).ToList();
            List<List<int>> matchingSubsets = new List<List<int>>();

            for (int i = 0; i < nCollections; i++)
            {
                List<int> biggestSubset = subsets.FirstOrDefault();
                var tempGalaxy = galaxy.Where(x => biggestSubset.Contains(x)).ToList();

                if (tempGalaxy.Count != 0)
                {
                    galaxy.RemoveAll(x => biggestSubset.Contains(x));

                    matchingSubsets.Add(biggestSubset);
                }
                subsets.Remove(biggestSubset);
            }

            Console.WriteLine($"({matchingSubsets.Count}) subsets");
            for (int i = 0; i < matchingSubsets.Count; i++)
            {
                Console.WriteLine($"{{ {string.Join(", ", matchingSubsets[i])} }}");
            }
        }
    }
}