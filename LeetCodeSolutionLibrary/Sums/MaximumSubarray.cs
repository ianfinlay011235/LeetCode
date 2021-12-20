using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary.Sums
{
    //https://leetcode.com/problems/maximum-subarray/
    //Optimized Solution: https://leetcode.com/problems/maximum-subarray/discuss/20193/DP-solution-and-some-thoughts
    public class MaximumSubarray
    {
        public int MaxSubArray(int[] nums)
        {
            int max = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                int cur = nums[i];
                max = Math.Max(max, cur);
                for (int j = i + 1; j < nums.Length; j++)
                {
                    cur += nums[j];
                    max = Math.Max(max, cur);
                }
            }
            return max;
        }
    }
}
