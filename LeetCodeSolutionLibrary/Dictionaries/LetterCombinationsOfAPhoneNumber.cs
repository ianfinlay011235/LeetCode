using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutionLibrary.Dictionaries
{
	//https://leetcode.com/problems/letter-combinations-of-a-phone-number

	public class LetterCombinationsOfAPhoneNumber
	{
		private static Dictionary<char, string> _dict = new Dictionary<char, string>
		{
			{ '2', "abc" },
			{ '3', "def" },
			{ '4', "ghi" },
			{ '5', "jkl" },
			{ '6', "mno" },
			{ '7', "pqrs" },
			{ '8', "tuv" },
			{ '9', "wxyz" }
		};

		/*
		 * Time Complexity: O(4^n) where n is the length of digits
		 * Space Complexity: O(4^n) where n is the length of digits
		 */
		public IList<string> LetterCombinations(string digits)
		{
			Queue<string> combos = new Queue<string>();

			if (digits == "") return combos.ToList();

			combos.Enqueue("");

            for (int i = 0; i < digits.Length; i++)
			{
				while (combos.Peek().Length == i)
				{
                    for (int j = 0; j < _dict[digits[i]].Length; j++)
                    {
						combos.Enqueue(combos.Peek() + _dict[digits[i]][j]);
                    }
					combos.Dequeue();
				}
			}

			return combos.ToList();
		}
	}
}