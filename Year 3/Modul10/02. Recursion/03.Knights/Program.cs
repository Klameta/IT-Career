namespace _03.Knights
{
    internal class Program
    {
        static int n;
        static int[,] board;
        static int[] dx = { 1, 2, 2, 1, -1, -2, -2, -1 };
        static int[] dy = { -2, -};
        stat
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            board = new int[n, n];

            PutKnight(0, 0);
        }

        private static void PutKnight(int row, int col)
        {
            if (row >= n || row < 0 ||
                col >= n || col < 0) return;
            if (board[row, col] > 0) return;


        }
    }
}