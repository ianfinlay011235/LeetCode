using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.Paths
{
    //https://leetcode.com/problems/minimum-path-sum/

    public class MinimumPathSum
    {
        int minSum = int.MaxValue;

        public int MinPathSum(int[][] grid)
        {
            MinPathSum(0, 0, 0, grid);
            return minSum;
        }

        public void MinPathSum(int sum, int x, int y, int[][] grid)
        {
            sum += grid[x][y];
            if (sum > minSum) return;

            if (grid.Length == x + 1 && grid[x].Length == y + 1)
            {
                if (sum < minSum) minSum = sum;
            }
            else if (grid.Length == x + 1)
            {
                MinPathSum(sum, x, y + 1, grid);
            }
            else if (grid[x].Length == y + 1)
            {
                MinPathSum(sum, x + 1, y, grid);
            }
            else {
                MinPathSum(sum, x + 1, y, grid);
                MinPathSum(sum, x, y + 1, grid);
            }
        }
    }
}
