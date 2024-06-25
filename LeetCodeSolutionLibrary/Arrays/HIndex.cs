using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutionLibrary.Arrays
{
	//leetcode.com/problems/h-index

	public class HIndex
	{
		/*
		 * Time Complexity: O(n) where n = citations.Length
		 * Space Complexity: O(n) where n = the number of disctinct values in citations
		 */
		public int FindH(int[] citations)
		{
			int n = citations.Length;

			int[] countArray = new int[n + 1];

            foreach (var citation in citations)
            {
                if (citation >= n)
                {
					countArray[n]++;
                }
                else
                {
					countArray[citation]++;
                }
            }

			int count = 0;
            for (int i = n; i >= 0; i--)
            {
				count += countArray[i];
                if (count >= i)
                {
                    return i;

                }
            }

			return 0;
		}
	}
}