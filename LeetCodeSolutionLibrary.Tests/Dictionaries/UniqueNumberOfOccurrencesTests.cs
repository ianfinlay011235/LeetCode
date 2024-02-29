using System;
using LeetCodeSolutionLibrary.Dictionaries;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Dictionaries
{
	public class UniqueNumberOfOccurrencesTests
	{
		[Theory]
		[InlineData(true, new int[] { 1, 2, 2, 1, 1, 3 })]
		[InlineData(false, new int[] { 1, 2 })]
		[InlineData(true, new int[] { -3, 0, 1, -3, 1, 1, 1, -3, 10, 0 })]
		public void UniqueOccurences_ShouldReturnExpectedValue(bool expected, int[] arr)
		{
			//Arrange
			UniqueNumberOfOccurrences solution = new UniqueNumberOfOccurrences();
			bool actual;

			//Act
			actual = solution.UniqueOccurences(arr);

			//Assert
			Assert.Equal(expected, actual);
		}
	}
}