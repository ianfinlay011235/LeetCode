using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutionLibrary.Dictionaries
{
	//https://leetcode.com/problems/count-elements-with-maximum-frequency

	public class CountElementsWithMaximumFrequency
	{
		/*
		 * Time Complexity: O(n) where n is the size of nums
		 * Space Complexity: O(n) where n is the number of distinct elements in nums
		 */
		public int MaxFrequencyElements(int[] nums)
		{
			Dictionary<int, int> dict = new Dictionary<int, int>();
			int maxFreq = 0;

            foreach (var num in nums)
            {
				dict[num] = dict.GetValueOrDefault(num, 0) + 1;
				maxFreq = Math.Max(maxFreq, dict[num]);
            }

			return dict.Where(kvp => kvp.Value == maxFreq).Count() * maxFreq;
		}
	}
}