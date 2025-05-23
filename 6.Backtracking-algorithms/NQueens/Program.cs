namespace NQueens
{
    internal class Program
    {
        const int N = 8;
        static void Main(string[] args)
        {
            int[] board = new int[N];
            PlaceQueen(0, board);
        }
        static void PlaceQueen(int row, int[] board)
        {
            if(row==N)
            {
                PrintBoard(board);
                return;
            }

            for (int col = 0; col < N; col++)
            {
                if(CanPlace(row, col, board))
                {
                    board[row]=col;
                    PlaceQueen(row+1, board);
                }

            }
        }
        static bool CanPlace(int row,int col, int[] board)
        {
            for (int i = 0; i < row; i++)
            {
                if (board[i]==col||Math.Abs(board[i]-col)
                    ==Math.Abs(i-row)) return false;

            }
            return true;
        }


        static void PrintBoard(int[] board)
        {
            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    Console.Write(board[row]==col?"f":".");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
