using System;
using LeetCodeSolutionLibrary.Arrays;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Arrays
{
	public class BestTimeToBuyAndSellStockTests
	{
		[Theory]
		[InlineData(5, new int[] { 7, 1, 5, 3, 6, 4 })]
		[InlineData(0, new int[] { 7, 6, 4, 3, 1 })]
		public void MaxProfit_ShouldReturnExpectedValue(int expected, int[] prices)
		{
			//Arrange
			BestTimeToBuyAndSellStock solution = new BestTimeToBuyAndSellStock();
			int actual;
			
			//Act
			 actual = solution.MaxProfit(prices);
			
			//Assert
			Assert.Equal(expected, actual);
		}
	}
}