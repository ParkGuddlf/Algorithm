//https://leetcode.com/problems/valid-sudoku/
public class ValidSudoku {
    public bool IsValidSudoku(char[][] board) {
    for (int x = 0; x < 9; x++)
    {
        List<char> xList = new List<char>();
        List<char> yList = new List<char>();
        for (int y = 0; y < 9; y++)
        {
            if (!xList.Contains(board[x][y]) || board[x][y] == '.')
                xList.Add(board[x][y]);
            else
                return false;

            if (!yList.Contains(board[y][x]) || board[y][x] == '.')
                yList.Add(board[y][x]);
            else
                return false;
        }
        List<char> boxList = new List<char>();
        for (int z = 0; z < 3; z++)
        {  
            for (int a = 0; a < 3; a++)
            {
                if(!boxList.Contains(board[((x%3)*3)+z][a+((x/3)*3)])|| board[((x%3)*3)+z][a+((x/3)*3)] == '.')
                    boxList.Add(board[((x%3)*3)+z][a+((x/3)*3)]);
                else
                    return false;
            }
        }
    }
    return true;
}
}