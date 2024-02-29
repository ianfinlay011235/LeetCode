using System;
using LeetCodeSolutionLibrary.Dictionaries;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Dictionaries
{
	public class MajorityElementTests
	{
		[Theory]
		[InlineData(3, new int[] { 3, 2, 3 })]
		[InlineData(2, new int[] { 2, 2, 1, 1, 1, 2, 2 })]
		public void FindMajorityElement_ShouldReturnExpectedValue(int expected, int[] nums)
		{
			//Arrange
			MajorityElement solution = new MajorityElement();
			int actual;
			
			//Act
			 actual = solution.FindMajorityElement(nums);
			
			//Assert
			Assert.Equal(expected, actual);
		}
	}
}