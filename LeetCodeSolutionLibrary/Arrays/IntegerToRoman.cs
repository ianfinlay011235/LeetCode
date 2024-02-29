using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolutionLibrary.Strings
{
	//https://leetcode.com/problems/integer-to-roman

	public class IntegerToRoman
	{
		private static readonly Dictionary<int, string> _dict = new Dictionary<int, string>
		{
			{ 1000, "M" },
			{ 900, "CM" },
			{ 500, "D" },
			{ 400, "CD" },
			{ 100, "C" },
			{ 90, "XC" },
			{ 50, "L" },
			{ 40, "XL"},
			{ 10, "X" },
            { 9, "IX"},
			{ 5, "V" },
			{ 4, "IV"},
			{ 1, "I" },
		};

		/*
		 * Time Complexity: O(1)
		 * Space Complexity: O(1)
		 */
		public string IntToRoman(int num)
		{
			StringBuilder output = new StringBuilder();

			foreach (var key in _dict.Keys)
			{
				while (num >= key)
				{
					output.Append(_dict[key]);
					num -= key;
				}
			}

			return output.ToString();
		}
	}
}