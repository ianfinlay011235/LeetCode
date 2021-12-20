using System;

namespace LeetCodeLibrary.DynamicProgramming
{
    //https://leetcode.com/problems/perfect-squares/
    public class PerfectSquares
    {
        public int NumSquares(int n)
        {
            int[] dp = new int[n + 1];
            for (int i = 0; i < dp.Length; i++)
            {
                dp[i] = i;
            }

            dp[0] = 0;
            int count = 1;
            while (count*count <= n)
            {
                int sq = count * count;
                for (int i = sq; i < n + 1; i++)
                {
                    dp[i] = Math.Min(dp[i-sq] + 1, dp[i]);
                }
                count++;
            }

            return dp[n];
            
        }

        private bool IsPerfectSquare(int n) => Math.Sqrt(n) % 1 == 0;
    }
}
