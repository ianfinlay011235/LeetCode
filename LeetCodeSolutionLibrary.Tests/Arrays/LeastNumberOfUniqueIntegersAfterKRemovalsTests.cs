using System;
using LeetCodeSolutionLibrary.Arrays;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Arrays
{
	public class LeastNumberOfUniqueIntegersAfterKRemovalsTests
	{
		[Theory]
		[InlineData(1, new int[] { 5, 5, 4 }, 1)]
		[InlineData(2, new int[] { 4, 3, 1, 1, 3, 3, 2 }, 3)]
		public void FindLeastNumOfUniqueInts_ShouldReturnExpectedValue(int expected, int[] arr, int k)
		{
			//Arrange
			LeastNumberOfUniqueIntegersAfterKRemovals solution = new LeastNumberOfUniqueIntegersAfterKRemovals();
			int actual;
			
			//Act
			 actual = solution.FindLeastNumOfUniqueInts(arr, k);
			
			//Assert
			Assert.Equal(expected, actual);
		}
	}
}