namespace _04.Labyrinth
{
    internal class Program
    {
        static int rows;
        static int cols;
        static char[,] labyrinth;
        List<char> path = new List<char>();

        static void Main(string[] args)
        {
            ReadLab();
        }

        private static void ReadLab()
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            labyrinth = new char[rows, cols];
            cols = input[1];
            rows = input[0];


            for (int row = 0; row < rows; row++)
            {
                char[] currRow = Console.ReadLine().ToCharArray();
                for (int col = 0; col < cols; col++)
                {
                    labyrinth[row, col] = currRow[col];
                }
            }
        }
    }
}