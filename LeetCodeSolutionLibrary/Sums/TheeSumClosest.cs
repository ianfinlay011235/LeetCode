using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutionLibrary.Sums
{
	//https://leetcode.com/problems/3sum-closest

	public class TheeSumClosest
	{
		/*
		 * Time Complexity: O()
		 * Space Complexity: O()
		 */
		public int Three_SumClosest(int[] nums, int target)
		{
			Array.Sort(nums);

			int closestSum = int.MaxValue;

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i] - 1)
                {
					continue;
                }

				int low = i + 1;
				int high = nums.Length - 1;

                while (low < high)
                {
					int sum = nums[i] + nums[low] + nums[high];

                    if (target - sum == 0) return sum;
					
					if (Math.Abs(target - sum) < Math.Abs(target - closestSum))
                    {
						closestSum = sum;
                    }

					int lastLow = nums[low];
					int lastHigh = nums[high];

                    while (sum < target && nums[low] == lastLow && low < high)
                    {
						low++;
                    }
					while (sum > target && nums[high] == lastHigh && low < high)
                    {
						high--;
                    }
                }
            }

			return closestSum;
		}
	}
}