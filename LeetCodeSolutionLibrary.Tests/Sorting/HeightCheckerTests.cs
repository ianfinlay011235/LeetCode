using System;
using LeetCodeSolutionLibrary.Sorting;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Sorting
{
	public class HeightCheckerTests
	{
		[Theory]
		[InlineData(3, new int[] { 1, 1, 4, 2, 1, 3 })]
		[InlineData(5, new int[] { 5, 1, 2, 3, 4 })]
		[InlineData(0, new int[] { 1, 2, 3, 4, 5 })]
		public void CheckHeights_ShouldReturnExpectedValue(int expected, int[] heights)
		{
			//Arrange
			HeightChecker solution = new HeightChecker();
			int actual;
			
			//Act
			 actual = solution.CheckHeights(heights);
			
			//Assert
			Assert.Equal(expected, actual);
		}
	}
}