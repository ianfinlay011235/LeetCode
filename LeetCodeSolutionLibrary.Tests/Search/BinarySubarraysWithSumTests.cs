using System;
using LeetCodeSolutionLibrary.Search;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Search
{
	public class BinarySubarraysWithSumTests
	{
		[Theory]
		[InlineData(4, new int[] { 1, 0, 1, 0, 1 }, 2)]
		[InlineData(15, new int[] { 0, 0, 0, 0, 0 }, 0)]
		public void NumSubarraysWithSum_ShouldReturnExpectedValue(int expected, int[] nums, int goal)
		{
			//Arrange
			BinarySubarraysWithSum solution = new BinarySubarraysWithSum();
			int actual;
			
			//Act
			 actual = solution.NumSubarraysWithSum(nums, goal);
			
			//Assert
			Assert.Equal(expected, actual);
		}
	}
}