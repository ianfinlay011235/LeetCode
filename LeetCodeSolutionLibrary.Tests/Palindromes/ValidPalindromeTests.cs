using System;
using LeetCodeSolutionLibrary.Palindromes;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Palindromes
{
	public class ValidPalindromeTests
	{
		[Theory]
		[InlineData(true, "A man, a plan, a canal: Panama")]
		[InlineData(false, "race a car")]
		[InlineData(true, " ")]
		public void IsPalindrome_ShouldExpectedValue(bool expected, string s)
		{
			//Arrange
			ValidPalindrome solution = new ValidPalindrome();
			bool actual;
			
			//Act
			 actual = solution.IsPalindrome(s);
			
			//Assert
			Assert.Equal(expected, actual);
		}
	}
}