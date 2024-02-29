using System;
using LeetCodeSolutionLibrary.Sums;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Sums
{
	public class TheeSumClosestTests
	{
		[Theory]
        [InlineData(2, new int[] { -1, 2, 1, -4 }, 1)]
        [InlineData(0, new int[] { 0, 0, 0 }, 1)]
        [InlineData(3, new int[] { 0, 1, 2 }, 3)]
		public void Three_SumClosest_ShouldReturnExpectedValue(int expected, int[] nums, int target)
		{
			//Arrange
			TheeSumClosest solution = new TheeSumClosest();
			int actual;
			
			//Act
			 actual = solution.Three_SumClosest(nums, target);
			
			//Assert
			Assert.Equal(expected, actual);
		}
	}
}