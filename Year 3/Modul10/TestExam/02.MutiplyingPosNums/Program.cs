namespace _02.MutiplyingPosNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int m = nums[0];
            int n = nums[1];

            Console.WriteLine(mult(m, n));
        }
        static int mult(int m, int n)
        {
            if (n == 1)
            {
                return m;
            }
            else
            {
                return mult(m, n - 1) + m;
            }
        }

    }
}