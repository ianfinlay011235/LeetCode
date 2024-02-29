using System;
using LeetCodeSolutionLibrary.Arrays;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Arrays
{
	public class RemoveDuplicatesFromSortedArrayIITests
	{
		[Theory]
		[InlineData(5, new int[] { 1, 1, 2, 2, 3, int.MinValue }, new int[] { 1, 1, 1, 2, 2, 3 })]
		[InlineData(7, new int[] { 0, 0, 1, 1, 2, 3, 3, int.MinValue, int.MinValue }, new int[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 })]
		[InlineData(1, new int[] { 1 }, new int[] { 1 })]
		[InlineData(2, new int[] { 1, 1 }, new int[] { 1, 1, 1 })]
		public void RemoveDuplicates_ShouldReturnExpectedValue(int expected, int[] expectedNums, int[] nums)
		{
			//Arrange
			RemoveDuplicatesFromSortedArrayII solution = new RemoveDuplicatesFromSortedArrayII();
			int actual;
			
			//Act
			 actual = solution.RemoveDuplicates(nums);
			
			//Assert
			Assert.Equal(expected, actual);
            for (int i = 0; i < actual; i++)
            {
				Assert.Equal(nums[i], expectedNums[i]);
            }
		}
	}
}