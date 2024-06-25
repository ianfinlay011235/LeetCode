using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutionLibrary.Palindromes
{
	//leetcode.com/problems/valid-palindrome

	public class ValidPalindrome
	{
		/*
		 * Time Complexity: O()
		 * Space Complexity: O()
		 */
		public bool IsPalindrome(string s)
		{
			s = s.ToLower();

			int left = 0;
			int right = s.Length - 1;

            while (left <= right)
            {
				if (!char.IsLetterOrDigit(s[left]))
				{
					left++;
				}
				else if (!char.IsLetterOrDigit(s[right]))
				{
					right--;
				}
				else if (s[left] != s[right])
				{
					return false;
				}
                else
				{
					left++;
					right--;
				}
            }

			return true;
		}
	}
}