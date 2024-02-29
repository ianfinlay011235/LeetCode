using System;
using LeetCodeSolutionLibrary.Arrays;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Arrays
{
	public class BestTimeToBuyAndSellStockIITests
	{
		[Theory]
		[InlineData(7, new int[] { 7, 1, 5, 3, 6, 4 })]
		[InlineData(4, new int[] { 1, 2, 3, 4, 5 })]
		[InlineData(0, new int[] { 7, 6, 4, 3, 1 })]
		public void MaxProfit_ShouldReturnExpectedValue(int expected, int[] prices)
		{
			//Arrange
			BestTimeToBuyAndSellStockII solution = new BestTimeToBuyAndSellStockII();
			int actual;
			
			//Act
			 actual = solution.MaxProfit(prices);
			
			//Assert
			Assert.Equal(expected, actual);
		}
	}
}