using System;
using LeetCodeSolutionLibrary.Dictionaries;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Dictionaries
{
	public class CountElementsWithMaximumFrequencyTests
	{
		[Theory]
		[InlineData(4, new int[] { 1, 2, 2, 3, 1, 4 })]
		[InlineData(5, new int[] { 1, 2, 3, 4, 5 })]
		public void MaxFrequencyElements_ShouldReturnExpectedValue(int expected, int[] nums)
		{
			//Arrange
			CountElementsWithMaximumFrequency solution = new CountElementsWithMaximumFrequency();
			int actual;
			
			//Act
			 actual = solution.MaxFrequencyElements(nums);
			
			//Assert
			Assert.Equal(expected, actual);
		}
	}
}