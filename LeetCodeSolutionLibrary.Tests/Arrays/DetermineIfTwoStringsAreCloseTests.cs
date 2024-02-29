using LeetCodeSolutionLibrary.Strings;
using System;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Strings
{
	public class DetermineIfTwoStringsAreCloseTests
	{
		[Theory]
		[InlineData(true, "abc", "bca")]
		[InlineData(false, "a", "aa")]
		[InlineData(true, "cabbba", "abbccc")]
		public void CloseStrings_ShouldReturnExpectedValue(bool expected, string word1, string word2)
		{
			//Arrange
			DetermineIfTwoStringsAreClose solution = new DetermineIfTwoStringsAreClose();
			bool actual;

			//Act
			actual = solution.CloseStrings(word1, word2);

			//Assert
			Assert.Equal(expected, actual);		}
	}
}