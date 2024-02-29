using System;
using LeetCodeSolutionLibrary.Strings;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Strings
{
	public class IntegerToRomanTests
	{
		[Theory]
		[InlineData("III", 3)]
		[InlineData("LVIII", 58)]
		[InlineData("MCMXCIV", 1994)]
		public void IntToRoman_ShouldReturnExpectedValue(string expected, int num)
		{
			//Arrange
			IntegerToRoman solution = new IntegerToRoman();
			string actual;
			
			//Act
			 actual = solution.IntToRoman(num);
			
			//Assert
			Assert.Equal(expected, actual);
		}
	}
}