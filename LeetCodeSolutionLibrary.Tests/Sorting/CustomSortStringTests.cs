using System;
using System.Linq;
using LeetCodeSolutionLibrary.Sorting;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Sorting
{
	public class CustomSortStringTests
	{
		[Theory]
		[InlineData(new string[] { "cbad", "dcba", "cdba", "cbda" }, "cba", "abcd")]
		[InlineData(new string[] { "bcad", "bacd", "bcda" }, "bcafg", "abcd")]
		public void CustomSort_ShouldReturnSatisfyingPermutation(string[] expected, string order, string s)
		{
			//Arrange
			CustomSortString solution = new CustomSortString();
			string actual;
			
			//Act
			 actual = solution.CustomSort(order, s);

			//Assert
			Assert.Contains(actual, expected);
		}
	}
}