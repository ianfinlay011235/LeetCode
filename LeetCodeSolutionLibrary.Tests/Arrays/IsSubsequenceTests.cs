using System;
using LeetCodeSolutionLibrary.Arrays;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Arrays
{
	public class IsSubsequenceTests
	{
		[Theory]
		[InlineData(true, "abc", "ahbgdc")]
		[InlineData(false, "axc", "ahbgdc")]
		public void IsSubsequence_ShouldReturnExpectedValue(bool expected, string s, string t)
		{
			//Arrange
			IsSubsequence solution = new IsSubsequence();
			bool actual;
			
			//Act
			 actual = solution.IsSubseq(s, t);
			
			//Assert
			Assert.Equal(expected, actual);
		}
	}
}