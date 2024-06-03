using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolutionLibrary.Sorting
{
	//https://leetcode.com/problems/custom-sort-string

	public class CustomSortString
	{
		/*
		 * Time Complexity: O(n + m) where n is the length of order and m is the length of s
		 * Space Complexity: O(n) where n in the length of s
		 */
		public string CustomSort(string order, string s)
		{
			Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (var c in s)
            {
				dict[c] = dict.GetValueOrDefault(c) + 1;
            }

			StringBuilder sb = new StringBuilder();

            foreach (var ch in order)
            {
                if (dict.ContainsKey(ch))
				{
					sb.Append(Enumerable.Repeat(ch, dict[ch]).ToArray());
					dict.Remove(ch);
				}
            }

            foreach (var key in dict.Keys)
            {
				sb.Append(Enumerable.Repeat(key, dict[key]).ToArray());
            }

			return sb.ToString();
		}
	}
}