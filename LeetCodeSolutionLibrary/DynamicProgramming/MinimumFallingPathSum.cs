using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutionLibrary.DynamicProgramming
{
	//https://leetcode.com/problems/minimum-falling-path-sum

	public class MinimumFallingPathSum
	{
		public int MinFallingPathSum(int[][] matrix)
		{
			int n = matrix.Length;

			int[][] memo = new int[n][];
            for (int i = 0; i < n; i++)
			{
				memo[i] = Enumerable.Repeat(int.MaxValue, n).ToArray();
			}

			int minSum = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
				minSum = Math.Min(minSum, MinFallingPathSum(0, i, matrix, memo));
            }

			return minSum;
		}

		public int MinFallingPathSum(int i, int j, int[][] matrix, int[][] memo)
        {
			//Last value in current falling path
			if (i == matrix.Length - 1)
			{
				memo[i][j] = matrix[i][j];
			}

			//Min value for current path already solved
			if (memo[i][j] != int.MaxValue)
			{
				return memo[i][j];
			}

			int left = int.MaxValue;
			int right = int.MaxValue;

			//Solve for left falling path
            if (j > 0)
            {
				left = MinFallingPathSum(i + 1, j - 1, matrix, memo);
            }

			//Solve for straight falling path
			int straight = MinFallingPathSum(i + 1, j, matrix, memo);

			//Solve for right falling path
            if (j < matrix.Length - 1)
            {
				right = MinFallingPathSum(i + 1, j + 1, matrix, memo);
			}

			//Update memo
			memo[i][j] = Math.Min(left, Math.Min(straight, right)) + matrix[i][j];

			return memo[i][j];
        }
	}
}