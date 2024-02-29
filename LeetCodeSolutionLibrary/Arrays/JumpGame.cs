using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutionLibrary.Arrays
{
	//https://leetcode.com/problems/jump-game

	public class JumpGame
	{
		/*
		 * Time Complexity: O(n) where n is the length of nums
		 * Space Complexity: O(1)
		 */
		public bool CanJump(int[] nums)
		{
            int reachable = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i > reachable) return false;

                reachable = Math.Max(reachable, i + nums[i]);
            }

            return true;
        }
        
        //Too Slow
        public bool CanJump(int[] nums, int index)
        {
            if (index >= nums.Length) return false;

            if (index == nums.Length - 1) return true;

            for (int i = nums[index]; i > 0; i--)
            {
                if (CanJump(nums, index + i))
                {
                    return true;
                }
            }

            return false;
        }
	}
}