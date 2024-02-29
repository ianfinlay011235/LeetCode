using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutionLibrary.Arrays
{
	//https://leetcode.com/problems/best-time-to-buy-and-sell-stock

	public class BestTimeToBuyAndSellStock
	{
		/*
		 * Time Complexity: O(n) where n is the length of prices
		 * Space Complexity: O(1)
		 */
		public int MaxProfit(int[] prices)
		{
			int max = 0;
			int low = 0;

            for (int i = 1; i < prices.Length; i++)
            {
				max = Math.Max(max, prices[i] - prices[low]);
				if (prices[i] < prices[low]) low = i;
            }

			return max;
		}
	}
}