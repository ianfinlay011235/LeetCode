using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutionLibrary.Sets
{
	//leetcode.com/problems/longest-palindrome

	public class LongestPalindrome
	{
		/*
		 * Time Complexity: O(n) where n = s.Length
		 * Space Complexity: O(1) since the hash set will never be > 52:
		 *		- 26 for lower-case characters 
		 *		- 26 for upper-case characters
		 */
		public int Longest(string s)
		{
			HashSet<char> set = new();
			int output = 0;

			foreach (var c in s)
            {
                if (set.Add(c) == false)
                {
					set.Remove(c);
					output += 2;
                }
            }

			output += set.Count > 0 ? 1 : 0;

			return output;
		}
	}
}