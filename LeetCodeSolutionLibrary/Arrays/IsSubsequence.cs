using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutionLibrary.Arrays
{
	//leetcode.com/problems/is-subsequence

	public class IsSubsequence
	{
		/*
		 * Time Complexity: O()
		 * Space Complexity: O()
		 */
		public bool IsSubseq(string s, string t)
		{
			int sIndex = 0;
			int tIndex = 0;

            while (sIndex < s.Length && tIndex < t.Length)
            {
                if (s[sIndex] == t[tIndex])
                {
					sIndex++;
				}
				tIndex++;
			}

			return sIndex == s.Length;
		}
	}
}