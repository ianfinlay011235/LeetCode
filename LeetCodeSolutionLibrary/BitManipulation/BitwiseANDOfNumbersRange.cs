using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutionLibrary.BitManipulation
{
	//https://leetcode.com/problems/bitwise-and-of-numbers-range

	public class BitwiseANDOfNumbersRange
	{
		/*
		 * Time Complexity: O(1)
		 * Space Complexity: O(1)
		 */
		public int RangeBitwiseAnd(int left, int right)
		{
			int count = 0;
            while (left != right)
            {
				left >>= 1;
				right >>= 1;
				count++;
            }
			return left << count;
		}
	}
}