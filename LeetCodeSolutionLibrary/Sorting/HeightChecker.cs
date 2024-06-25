using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutionLibrary.Sorting
{
	//leetcode.com/problems/height-checker

	public class HeightChecker
	{
		/*
		 * Time Complexity: O(n log n) where n = heights.Length...
		 *	Array.Sort() uses "introspective" sort which is a hybrid sorting algorithm that is
		 *	O(n log n) operation for the worst case: https://learn.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-8.0
		 *	
		 * Space Complexity: O(n) where n = heights.Length...
		 *	We copy the values in heights to a new array to then sort and use for comparison	
		 */
		public int CheckHeights(int[] heights)
		{
			int[] expected = new int[heights.Length];

			Array.Copy(heights, expected, heights.Length);
			Array.Sort(heights);

			int count = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                if (heights[i] != expected[i])
                {
					count++;
                }
            }

			return count;
		}
	}
}