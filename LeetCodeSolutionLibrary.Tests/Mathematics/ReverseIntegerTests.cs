using System;
using LeetCodeSolutionLibrary.Mathematics;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Mathematics
{
	public class ReverseIntegerTests
	{
		[Theory]
        [InlineData(321, 123)]
        [InlineData(-321, -123)]
        [InlineData(21, 120)]
        [InlineData(0, 1534236469)]
		[InlineData(0, -2147483648)]
		public void Reverse_ShouldReturnExpectedValue(int expected, int x)
		{
			//Arrange
			ReverseInteger solution = new ReverseInteger();
			int actual;
			
			//Act
			 actual = solution.Reverse(x);
			
			//Assert
			Assert.Equal(expected, actual);
		}
	}
}