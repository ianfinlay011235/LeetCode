using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutionLibrary.Arrays
{
	//https://leetcode.com/problems/container-with-most-water/

	public class ContainerWithMostWater
	{
		/*
		 * Time Complexity: O(n)
		 * Space Complexity: O(1)
		 */
		public int MaxArea(int[] height)
		{
			int left = 0;
			int right = height.Length - 1;
			int max = 0;

            while (left < right)
            {
				int current = Math.Min(height[left], height[right]) * (right - left);
				max = Math.Max(max, current);

				if (height[left] < height[right])
				{
					left++;
				}
				else
				{
					right--;
				}
            }

			return max;
		}
	}
}