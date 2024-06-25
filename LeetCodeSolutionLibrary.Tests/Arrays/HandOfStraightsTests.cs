using System;
using LeetCodeSolutionLibrary.Arrays;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Arrays
{
	public class HandOfStraightsTests
	{
		[Theory]
		[InlineData(true, new int[] { 1, 2, 3, 6, 2, 3, 4, 7, 8 }, 3)]
		[InlineData(false, new int[] { 1, 2, 3, 4, 5 }, 4)]
		[InlineData(true, new int[] { 1, 2, 3 }, 1)]
		//[InlineData(true, new int[] { 2, 1 }, 2)]
		public void IsNStraightHand_ShouldReturnExpectedValue(bool expected, int[] hand, int groupSize)
		{
			//Arrange
			HandOfStraights solution = new HandOfStraights();
			bool actual;
			
			//Act
			 actual = solution.IsNStraightHand(hand, groupSize);
			
			//Assert
			Assert.Equal(expected, actual);
		}
	}
}