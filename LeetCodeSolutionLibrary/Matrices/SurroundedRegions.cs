namespace LeetCodeLibrary.Matrices
{
    //https://leetcode.com/problems/surrounded-regions/
    public class SurroundedRegions
    {
        public void Solve(char[][] board)
        {
            MarkBorder0s(board);
            MarkZerosAttachedToBorder0s(board);
            Convert1sTo0sAnd0sToXs(board);
        }

        private void Convert1sTo0sAnd0sToXs(char[][] board)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] == '1')
                        board[i][j] = 'O';
                    else if (board[i][j] == 'O')
                        board[i][j] = 'X';
                }
            }
        }

        private void MarkZerosAttachedToBorder0s(char[][] board)
        {
            for (int i = 1; i < board.Length - 1; i++)
            {
                for (int j = 1; j < board[i].Length - 1; j++)
                {
                    if (board[i][j] == 'O' && IsConnectedToZero(board, i, j))
                        board[i][j] = '1';
                }
            }
        }

        private void MarkBorder0s(char[][] board)
        {
            for (int i = 0; i < board.Length; i++)
            {
                if (board[i][0] == 'O')
                    board[i][0] = '1';

                if (board[i][board[i].Length - 1] == 'O')
                    board[i][board[i].Length - 1] = '1';
            }

            for (int i = 0; i < board[0].Length; i++)
            {
                if (board[0][i] == 'O')
                    board[0][i] = '1';

                if (board[board.Length - 1][i] == 'O')
                    board[board.Length - 1][i] = '1';
            }
        }

        private bool IsConnectedToZero(char[][] board, int i, int j) =>
            board[i - 1][j] == '1' ||
            board[i + 1][j] == '1' ||
            board[i][j - 1] == '1' ||
            board[i][j + 1] == '1';
    }
}
