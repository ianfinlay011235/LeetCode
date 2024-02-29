using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutionLibrary.Arrays
{
	//https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii

	public class BestTimeToBuyAndSellStockII
	{
		/*
		 * Time Complexity: O(n) where n is the length of prices
		 * Space Complexity: O(1)
		 */
		public int MaxProfit(int[] prices)
		{
			int profit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                {
					profit += prices[i] - prices[i - 1];
                }
            }
			return profit;
		}
	}
}