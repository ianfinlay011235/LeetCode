using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutionLibrary.Arrays
{
	//leetcode.com/problems/product-of-array-except-self

	public class ProductOfArrayExceptSelf
	{
		/*
		 * Time Complexity: O()
		 * Space Complexity: O()
		 */
		public int[] ProductExceptSelf(int[] nums)
		{
			int n = nums.Length;
			int[] ans = new int[n];

			int[] prefixSum = new int[n];
			prefixSum[0] = 1;

			int[] suffixSum = new int[n];
			suffixSum[n - 1] = 1;

			//Populate prefix sum array
			for (int i = 1; i < n; i++)
            {
				prefixSum[i] = prefixSum[i - 1] * nums[i - 1];
            }

			//Populate suffix sum array
			for (int i = n-2; i >= 0; i--)
            {
				suffixSum[i] = suffixSum[i + 1] * nums[i + 1];
            }

			//Populate answer array
            for (int i = 0; i < n; i++)
            {
				ans[i] = prefixSum[i] * suffixSum[i];
            }

			return ans;
		}
	}
}