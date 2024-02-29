using System;
using LeetCodeSolutionLibrary.BitManipulation;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.BitManipulation
{
	public class BitwiseANDOfNumbersRangeTests
	{
		[Theory]
        [InlineData(4, 5, 7)]
		[InlineData(0, 0, 0)]
		[InlineData(0, 1, 2147483647)]
		public void RangeBitwiseAnd_ShouldReturnExpectedValue(int expected, int left, int right)
		{
			//Arrange
			BitwiseANDOfNumbersRange solution = new BitwiseANDOfNumbersRange();
			int actual;
			
			//Act
			 actual = solution.RangeBitwiseAnd(left, right);
			
			//Assert
			Assert.Equal(expected, actual);
		}
	}
}