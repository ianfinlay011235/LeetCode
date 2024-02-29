using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutionLibrary.Arrays
{
	//https://leetcode.com/problems/least-number-of-unique-integers-after-k-removals

	public class LeastNumberOfUniqueIntegersAfterKRemovals
	{
		/*
		 * Time Complexity: O(n) where n is the length of arr
		 * Space Complexity: O(n) where n is the number of unique values in arr
		 */
		public int FindLeastNumOfUniqueInts(int[] arr, int k)
		{
			Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var key in arr)
            {
				dict[key] = dict.GetValueOrDefault(key, 0) + 1;
            }

            foreach (var key in dict.Keys.OrderBy(k => dict[k]))
            {
                if (k < dict[key]) break;
				k -= dict[key];
				dict.Remove(key);
			}

			return dict.Count;
		}
	}
}