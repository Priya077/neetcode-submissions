public class Solution {
    public bool IsValidSudoku(char[][] board) {
        for(int i=0;i<9;i++)
        {
            HashSet<char>seen=new HashSet<char>();
            for(int j=0;j<9;j++)
            {
                if (board[i][j] == '.') continue;
                if(seen.Contains(board[i][j])) return false;
                seen.Add(board[i][j]);
            }
        }
        for(int j=0;j<9;j++)
        {
            HashSet<char>seen=new HashSet<char>();
            for(int i=0;i<9;i++)
            {
                if (board[i][j] == '.') continue;
                if(seen.Contains(board[i][j])) return false;
                seen.Add(board[i][j]);
            }
        }
        for(int sq=0;sq<9;sq++)
        {
            HashSet<char>seen=new HashSet<char>();
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    int row = (sq / 3) * 3 + i;
                    int col = (sq % 3) * 3 + j;
                    if (board[row][col] == '.') continue;
                    if (seen.Contains(board[row][col])) return false;
                    seen.Add(board[row][col]);
                }
            }
        }
        return true;
    }
}
