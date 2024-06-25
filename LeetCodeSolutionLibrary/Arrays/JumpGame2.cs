using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutionLibrary.Arrays
{
	//leetcode.com/problems/jump-game-ii

	public class JumpGame2
	{
		public int Jump(int[] nums)
        {
			if (nums.Length == 1) 
            {
				return 0;
			}

			int[] jumpArr = Enumerable.Repeat(int.MaxValue, nums.Length).ToArray();
			jumpArr[0] = 0;

			int target = nums.Length - 1;
			int jumps = 0;
			int cur = 0;

			while (cur < target)
			{
				jumps = jumpArr[cur];

				for (int i = cur + 1; i <= cur + nums[cur] && i <= target; i++)
                {
                    if (jumpArr[i] == int.MaxValue)
                    {
						jumpArr[i] = jumps + 1;
                    }
                    else
                    {
						jumpArr[i] = Math.Min(jumpArr[i], jumps + 1);
                    }
                }

				cur++;
            }

			return jumpArr[target];
		}
	}
}