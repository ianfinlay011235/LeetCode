using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary.DynamicProgramming
{
    public class LargestDivisibleSubset
    {
        public IList<int> LargestSubset(int[] nums)
        {
            Array.Sort(nums);

            //Finding the largest divisible subset
            int max = 0;
            int n = nums.Length;
            int[] dp = Enumerable.Repeat(1, n).ToArray();

            for (int i = 0; i < n; i++) //O(n^2)
            {
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] % nums[j] == 0)
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                    }
                }

                max = dp[i] > dp[max] ? i : max;
            }

            //Backtrack to generate subset
            List<int> subset = new List<int>();
            int num = nums[max];
            int size = dp[max];

            for (int i = max; i >= 0; i--) //O(n)
            {
                if (num % nums[i] == 0 && size == dp[i])
                {
                    subset.Add(nums[i]);
                    num = nums[i];
                    size--;
                }
            }

            return subset;
        }
    }
}
