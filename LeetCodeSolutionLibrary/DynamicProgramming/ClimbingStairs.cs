using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutionLibrary.DynamicProgramming
{
	//https://leetcode.com/problems/climbing-stairs
	public class ClimbingStairs
	{
		public int ClimbStairs(int n)
		{
			var memo = Enumerable.Repeat(-1, n).ToArray();
			return Solve(0, n, memo);
		}

		public int Solve(int i, int n, int[] memo)
        {
			if (i == n) return 1;
			if (i > n) return 0;
			if (memo[i] != -1) return memo[i];

			memo[i] = Solve(i + 1, n, memo) + Solve(i + 2, n, memo);

			return memo[i];
        }
	}
}