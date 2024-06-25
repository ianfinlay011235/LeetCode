using System;
using LeetCodeSolutionLibrary.Arrays;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Arrays
{
	public class JumpGame2Tests
	{
		[Theory]
		[InlineData(2, new int[] { 2, 3, 1, 1, 4 })]
		[InlineData(2, new int[] { 2, 3, 0, 1, 4 })]
		[InlineData(1, new int[] { 2, 1 })]
		[InlineData(1, new int[] { 3, 2, 1 })]
		public void Jump_ShouldReturnExpectedValue(int expected, int[] nums)
		{
			//Arrange
			JumpGame2 solution = new JumpGame2();
			int actual;
			
			//Act
			 actual = solution.Jump(nums);
			
			//Assert
			Assert.Equal(expected, actual);
		}
	}
}