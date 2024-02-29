using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutionLibrary.Dictionaries
{
	//https://leetcode.com/problems/majority-element

	public class MajorityElement
	{
		/*
		 * Time Complexity: O(n) where n is the length of nums
		 * Space Complexity: O(n) where n is the number of unique values in nums
		 */
		public int FindMajorityElement(int[] nums)
		{
			Dictionary<int, int> dict = new Dictionary<int, int>();
			int goal = nums.Length / 2;

            foreach (var num in nums)
            {
				dict[num] = dict.GetValueOrDefault(num, 0) + 1;
				if (dict[num] > goal) return num;
            }

			return -1;
		}
	}
}