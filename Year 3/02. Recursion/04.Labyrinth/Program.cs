namespace _04.Labyrinth
{
    internal class Program
    {
        static int rows;
        static int cols;
        static char[,] labyrinth;
        static List<char> path = new List<char>();

        static void Main(string[] args)
        {
            ReadLab();
            FindPaths(0, 0, 'S');
        }

        private static void FindPaths(int row, int col, char direction)
        {
            if (row == rows || col < 0 || col == cols || col < 0) return;
            if (labyrinth[row, col] == '*') return;

            if (labyrinth[row, col] == 'e')
            {
                Console.WriteLine(string.Join("", path.Skip(1)));
            }
        }

        private static void ReadLab()
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            labyrinth = new char[rows, cols];
            rows = input[0];
            cols = input[1];


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