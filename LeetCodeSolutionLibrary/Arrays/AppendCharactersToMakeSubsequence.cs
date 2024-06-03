using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutionLibrary.Arrays
{
	//https://leetcode.com/problems/append-characters-to-string-to-make-subsequence

	public class AppendCharactersToMakeSubsequence
	{
		/*
		 * Time Complexity: O(n) where n = min(s.Length, t.Length)
		 * Space Complexity: O(1)
		 */
		public int AppendCharacters(string s, string t)
		{
            int sPointer = 0;
            int tPointer = 0;

            while (sPointer < s.Length && tPointer < t.Length)
            {
                if (s[sPointer] == t[tPointer])
                {
                    tPointer++;
                }
                sPointer++;
            }

            return t.Length - tPointer;
        }
	}
}