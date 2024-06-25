using System;
using LeetCodeSolutionLibrary.Arrays;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Arrays
{
	public class ProductOfArrayExceptSelfTests
	{
		[Theory]
		[InlineData(new int[] { 24, 12, 8, 6 }, new int[] { 1, 2, 3, 4 })]
		[InlineData(new int[] { 0, 0, 9, 0, 0  }, new int[] { -1, 1, 0, -3, 3 })]
		public void ProductExceptSelf_ShouldReturnExpectedValue(int[] expected, int[] nums)
		{
			//Arrange
			ProductOfArrayExceptSelf solution = new ProductOfArrayExceptSelf();
			int[] actual;
			
			//Act
			 actual = solution.ProductExceptSelf(nums);
			
			//Assert
			Assert.Equal(expected, actual);
		}
	}
}