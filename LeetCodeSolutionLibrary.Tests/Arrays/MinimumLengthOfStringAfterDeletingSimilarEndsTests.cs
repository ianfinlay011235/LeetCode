using System;
using LeetCodeSolutionLibrary.Arrays;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Arrays
{
	public class MinimumLengthOfStringAfterDeletingSimilarEndsTests
	{
		[Theory]
		[InlineData(2, "ca")]
		[InlineData(0, "cabaabac")]
		[InlineData(3, "aabccabba")]
		[InlineData(1, "bbbbbbbbbbbbbbbbbbbbbbbbbbbabbbbbbbbbbbbbbbccbcbcbccbbabbb")]
		[InlineData(0, "bbbbbbbbbbbbbbbbbbb")]		
		public void MinimumLength_ShouldReturnExpectedValue(int expected, string s)
		{
			//Arrange
			MinimumLengthOfStringAfterDeletingSimilarEnds solution = new MinimumLengthOfStringAfterDeletingSimilarEnds();
			int actual;
			
			//Act
			 actual = solution.MinimumLength(s);
			
			//Assert
			Assert.Equal(expected, actual);
		}
	}
}