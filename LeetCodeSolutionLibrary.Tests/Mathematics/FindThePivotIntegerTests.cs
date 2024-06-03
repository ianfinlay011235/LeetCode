using System;
using LeetCodeSolutionLibrary.Mathematics;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Mathematics
{
	public class FindThePivotIntegerTests
	{
		[Theory]
		[InlineData(6, 8)]
		[InlineData(1, 1)]
		[InlineData(-1, 4)]
		public void PivotInteger_ShouldReturnExpectedValue(int expected, int n)
		{
			//Arrange
			FindThePivotInteger solution = new FindThePivotInteger();
			int actual;
			
			//Act
			 actual = solution.PivotInteger(n);
			
			//Assert
			Assert.Equal(expected, actual);
		}
	}
}