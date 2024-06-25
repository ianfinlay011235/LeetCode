using System;
using LeetCodeSolutionLibrary.Arrays;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Arrays
{
	public class HIndexTests
	{
		[Theory]
		[InlineData(3, new int[] { 3, 0, 6, 1, 5 })]
		[InlineData(1, new int[] { 1, 3, 1 })]
		[InlineData(1, new int[] { 100 })]
		[InlineData(2, new int[] { 11, 15 })]
		[InlineData(2, new int[] { 4, 4, 0, 0 })]
		public void FindH_ShouldReturnExpectedValue(int expected, int[] citations)
		{
			//Arrange
			HIndex solution = new HIndex();
			int actual;
			
			//Act
			 actual = solution.FindH(citations);
			
			//Assert
			Assert.Equal(expected, actual);
		}
	}
}