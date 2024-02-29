using System;
using LeetCodeSolutionLibrary.DynamicProgramming;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.DynamicProgramming
{
	public class ClimbingStairsTests
	{
		[Theory]
		[InlineData(2, 2)]
		[InlineData(3, 3)]
		[InlineData(5, 4)]
		[InlineData(8, 5)]
		[InlineData(13, 6)]
		public void ClimbStairs_ShouldReturnExpectedValue(int expected, int n)
		{
			//Arrange
			ClimbingStairs soltuion = new ClimbingStairs();
			int actual;
			
			//Act
			actual = soltuion.ClimbStairs(n);
			
			//Assert
			Assert.Equal(expected, actual);
		}
	}
}