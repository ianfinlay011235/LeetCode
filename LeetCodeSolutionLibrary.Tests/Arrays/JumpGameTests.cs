using System;
using LeetCodeSolutionLibrary.Arrays;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Arrays
{
	public class JumpGameTests
	{
		[Theory]
		[InlineData(true, new int[] { 2, 3, 1, 1, 4 })]
		[InlineData(false, new int[] { 3, 2, 1, 0, 4 })]
		[InlineData(true, new int[] { 0 })]
		public void CanJump_ShouldReturnExpectedValue(bool expected, int[] nums)
		{
			//Arrange
			JumpGame solution = new JumpGame();
			bool actual;
			
			//Act
			 actual = solution.CanJump(nums);
			
			//Assert
			Assert.Equal(expected, actual);
		}
	}
}