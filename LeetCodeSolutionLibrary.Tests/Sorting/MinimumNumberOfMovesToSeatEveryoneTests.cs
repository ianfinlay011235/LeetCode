using System;
using LeetCodeSolutionLibrary.Sorting;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Sorting
{
	public class MinimumNumberOfMovesToSeatEveryoneTests
	{
		[Theory]
		[InlineData(4, new int[] { 3, 1, 5 }, new int[] { 2, 7, 4 })]
		[InlineData(7, new int[] { 4, 1, 5, 9 }, new int[] { 1, 3, 2, 6 })]
		[InlineData(4, new int[] { 2, 2, 6, 6 }, new int[] { 1, 3, 2, 6 })]
		public void MinMovesToSeat_ShouldReturnExpectedValue(int expected, int[] seats, int[] students)
		{
			//Arrange
			MinimumNumberOfMovesToSeatEveryone solution = new MinimumNumberOfMovesToSeatEveryone();
			int actual;
			
			//Act
			 actual = solution.MinMovesToSeat(seats, students);
			
			//Assert
			Assert.Equal(expected, actual);
		}
	}
}