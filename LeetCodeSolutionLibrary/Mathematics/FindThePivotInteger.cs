using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutionLibrary.Mathematics
{
	//https://leetcode.com/problems/find-the-pivot-integer

	public class FindThePivotInteger
	{
		/*
		 * Time Complexity: O(n) where n is the size of the input n
		 * Space Complexity: O(1)
		 */
		public int PivotInteger(int n)
		{
			if (n == 1) return 1;

			int lSum = 0;
			int rSum = 0;

            for (int i = 0, j = n; i < j;)
            {
                if (lSum <= rSum)
                {
                    lSum += i++;
                }
                else if (rSum <= lSum)
                {
                    rSum += j--;
                }

                if (lSum == rSum && i == j)
                {
                    return i;
                }
            }

			return -1;
		}
	}
}