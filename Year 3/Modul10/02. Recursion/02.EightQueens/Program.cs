namespace _02.EightQueens
{
    internal class Program
    {
        public static int cnt = 0;
        public static int n = 8;
        static bool[,] board = new bool[n, n];
        public static List<int> attackedRows = new List<int>();
        public static List<int> attackedCols = new List<int>();
        public static List<int> attackedLeftDiags = new List<int>();
        public static List<int> attackedRightDiags = new List<int>();
        static void Main(string[] args)
        {
            PutQueens(0);
        }

        private static void PutQueens(int row)
        {
            if (row == n)
            {
                PrintBoard();
            }

            for (int col = 0; col < n; col++)
            {
                if (CanPlaceQueen(row, col))
                {
                    SetQueen(row, col);
                    PutQueens(row + 1);
                    RemoveQueen(row, col);
                }
            }
        }

        private static void PrintBoard()
        {
            cnt++;
            Console.WriteLine(cnt);
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (board[row,col])
                    {
                        Console.Write($"1 ");
                    }
                    else
                    {
                        Console.Write($"0 ");
                    }
                }
                Console.WriteLine();
            }
        
        }

        private static void RemoveQueen(int row, int col)
        {
            board[row, col] = false; 

            attackedCols.Remove(col);
            attackedRows.Remove(row);
            attackedRightDiags.Remove(row + col);
            attackedLeftDiags.Remove(col - row);
        }

        private static void SetQueen(int row, int col)
        {
            board[row, col] = true;

            attackedCols.Add(col);
            attackedRows.Add(row);
            attackedRightDiags.Add(row + col);
            attackedLeftDiags.Add(col - row);
        }

        private static bool CanPlaceQueen(int row, int col)
        {
            if (attackedRows.Contains(row) ||
                attackedCols.Contains(col) ||
                attackedLeftDiags.Contains(col - row) ||
                attackedRightDiags.Contains(col + row))
            {
                return false;
            }
            return true;
        }
    }
}