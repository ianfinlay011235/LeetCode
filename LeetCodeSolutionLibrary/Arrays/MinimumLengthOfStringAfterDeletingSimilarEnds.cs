using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutionLibrary.Arrays
{
	//https://leetcode.com/problems/minimum-length-of-string-after-deleting-similar-ends

	public class MinimumLengthOfStringAfterDeletingSimilarEnds
	{
		/*
		 * Time Complexity: O(n) where n is the length of s
		 * Space Complexity: O(1)
		 */
		public int MinimumLength(string s)
		{
			int left = 0;
			int right = s.Length - 1;
			char current;

            while (left < right)
            {
				if (s[left] != s[right]) break;

				current = s[left];

				while (left <= right && s[left] == current) left++;
				
				while (left <= right && s[right] == current) right--;
			}

			return right - left + 1;
		}
	}
}