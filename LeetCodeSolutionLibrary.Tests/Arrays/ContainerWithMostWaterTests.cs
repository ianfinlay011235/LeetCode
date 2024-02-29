using System;
using LeetCodeSolutionLibrary.Arrays;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Arrays
{
	public class ContainerWithMostWaterTests
	{
		[Theory]
		[InlineData(49, new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 })]
		[InlineData(1, new int[] { 1, 1 })]
		public void MaxArea_ShouldReturnExpectedValue(int expected, int[] height)
		{
			//Arrange
			ContainerWithMostWater solution = new ContainerWithMostWater();
			int actual;
			
			//Act
			 actual = solution.MaxArea(height);
			
			//Assert
			Assert.Equal(expected, actual);
		}
	}
}