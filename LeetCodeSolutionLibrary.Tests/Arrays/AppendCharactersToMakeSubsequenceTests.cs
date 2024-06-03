using System;
using LeetCodeSolutionLibrary.Arrays;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Arrays
{
	public class AppendCharactersToMakeSubsequenceTests
	{
		[Theory]
		[InlineData(4, "coaching", "coding")]
		[InlineData(0, "abcde", "a")]
		[InlineData(5, "z", "abcde")]
		public void AppendCharacters_ShouldReturnExpectedValue(int expected, string s, string t)
		{
			//Arrange
			AppendCharactersToMakeSubsequence solution = new AppendCharactersToMakeSubsequence();
			int actual;
			
			//Act
			 actual = solution.AppendCharacters(s, t);
			
			//Assert
			Assert.Equal(expected, actual);
		}
	}
}