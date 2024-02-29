using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutionLibrary.Strings
{
	//https://leetcode.com/problems/first-unique-character-in-a-string

	public class FirstUniqueCharacterInString
	{
		/*
		 * Time Complexity: O(n)
		 * Space Complexity: O(1)
		 */
		public int FirstUniqChar(string s)
		{
			Dictionary<char, int> d = new Dictionary<char, int>(26);

            foreach (var c in s)
            {
				d[c] = d.GetValueOrDefault(c) + 1;
            }

            for (int i = 0; i < s.Length; i++)
            {
				if (d[s[i]] == 1) return i;
            }

			return -1;
		}
	}
}