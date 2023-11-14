using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.Arrays
{
    //https://leetcode.com/problems/minimize-maximum-of-array/

    public class MinimizeMaximumOfArray
    {
        public int MinimizeArrayValue(int[] nums)
        {
            //enumerate through nums where i >= 1 and i < n
            //looking for nums[i] = max value and nums[i] > nums[i-1]
            //if nums[0] is max, return nums[0]

            int max = nums.Max();

            while (nums[0] < max)
            {
                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[i] > nums[i - 1])
                    {
                        nums[i]--;
                        nums[i - 1]++;
                    }
                }
                max = nums.Max();
            }

            return max;
        }
    }
}
