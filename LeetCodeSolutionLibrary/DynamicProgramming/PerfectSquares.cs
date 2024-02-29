using System;
using System.Linq;

namespace LeetCodeLibrary.DynamicProgramming
{
    //https://leetcode.com/problems/perfect-squares/

    public class PerfectSquares
    {
        public int NumSquares(int n)
        {
            int[] dp = Enumerable.Repeat(int.MaxValue, n + 1).ToArray();

            dp[0] = 0;

            for (int i = 1; i <= n; i++)
            {
                int min = int.MaxValue;
                for (int j = 1; j * j <= i; j++)
                {
                    min = Math.Min(min, dp[i - j * j] + 1);
                }
                dp[i] = min;
            }

            return dp[n];            
        }
    }
}
