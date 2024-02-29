using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutionLibrary.Mathematics
{
	//https://leetcode.com/problems/reverse-integer

	public class ReverseInteger
	{
		/*
		 * Time Complexity: O(n) where n in the number of digits in x
		 * Space Complexity: O(1)
		 */
		public int Reverse(int x)
		{
			if (x == 0 || x == int.MinValue) return 0;

			int result = 0;

            while (x != 0)
            {
				int remainder = x % 10;
				int temp = result * 10 + remainder;

				if ((temp - remainder) / 10 != result) return 0;

				result = temp;

				x /= 10;
            }

			return result;
		}
	}
}