using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutionLibrary.Search
{
	//https://leetcode.com/problems/binary-subarrays-with-sum
	
	//Sliding window approach from solution:
	//https://leetcode.com/problems/binary-subarrays-with-sum/solutions/4872579/solved-with-sliding-window-brute-force-yes-with-brute-force-also/?envType=daily-question&envId=2024-03-14

	public class BinarySubarraysWithSum
	{
		/*
		 * Time Complexity: O()
		 * Space Complexity: O()
		 */
		public int NumSubarraysWithSum(int[] nums, int goal)
		{
			int i = 0;
			int count = 0;
			int result = 0;

            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] == 1)
                {
					goal--;
					count = 0;
                }

                while (goal == 0 && i <= j)
                {
					goal += nums[i];
					i++;
					count++;
                    if (i > j - goal + 1)
                    {
						break;
                    }
                }

                while (goal < 0)
                {
					goal += nums[i];
					i++;
                }

				result += count;
            }

			return result;
		}
	}
}