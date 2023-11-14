using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.Search
{
    //https://leetcode.com/problems/number-of-closed-islands/

    public class NumberOfClosedIslands
    {
        public int ClosedIslands(int[][] grid)
        {
            int count = 0;

            int[][] memo = new int[grid.Length][];
            for (int i = 0; i < memo.Length; i++)
            {
                memo[i] = new int[grid[0].Length];
                for (int j = 0; j < memo[i].Length; j++)
                {
                    memo[i][j] = -1;
                }
            }

            for (int i = 1; i < grid.Length - 1; i++)
            {
                for (int j = 1; j < grid[0].Length - 1; j++)
                {
                    if (memo[i][j] == -1 && grid[i][j] == 0)
                    {
                        if (LandIsClosed(i, j, grid, memo))
                        {
                            count++;
                        }
                    }
                }
            }

            return count;
        }

        private bool LandIsClosed(int i, int j, int[][] grid, int[][] memo, HashSet<(int, int)> path = null)
        {
            if (path == null)
            {
                path = new HashSet<(int, int)>();
            }

            if (memo[i][j] == 0)
            {
                return false;
            }
            else if (memo[i][j] == 1)
            {
                return true;
            }

            //revisiting a square in current path
            if (path.Add((i, j)) == false) 
            {
                return true;
            }

            //If square is on the edge of the grid
            if (i < 1 || i > grid.Length - 2 || j < 1 || j > grid[0].Length - 2)
            {
                foreach (var coord in path)
                {
                    memo[coord.Item1][coord.Item2] = 0;
                }
                return false;
            }

            memo[i][j] = 1;

            bool isNorthValid = grid[i - 1][j] == 1 || LandIsClosed(i - 1, j, grid, memo, path);
            bool isEastValid = grid[i][j + 1] == 1 || LandIsClosed(i, j + 1, grid, memo, path);
            bool isSouthValid = grid[i + 1][j] == 1 || LandIsClosed(i + 1, j, grid, memo, path);
            bool isWestValid = grid[i][j - 1] == 1 || LandIsClosed(i, j - 1, grid, memo, path);

            return
                isNorthValid &&
                isEastValid &&
                isSouthValid &&
                isWestValid;
        }
    }
}
