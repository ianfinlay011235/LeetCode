using System;
using LeetCodeSolutionLibrary.Arrays;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Arrays
{
	public class AverageWaitingTimeTests
	{
		[Theory]
        [ClassData(typeof(AverageWaitingTimeDataGenerator))]
        public void AverageWaitingTime_ShouldReturnExpectedValue(double expected, int[][] customers)
		{
			//Arrange
			AverageWaitingTime solution = new AverageWaitingTime();
			double actual;
			
			//Act
			 actual = solution.AverageWait(customers);
			
			//Assert
			Assert.True(expected > actual - Math.Pow(10, -5) && expected < actual + Math.Pow(10, -5));
		}
	}

	public class AverageWaitingTimeDataGenerator : TheoryData<double, int[][]>
	{
		public AverageWaitingTimeDataGenerator()
		{
            Add(5.00000, [[1, 2], [2, 5], [4, 3]]);
            Add(3.25000, [[5, 2], [5, 4], [10, 3], [20, 1]]);
        }
	}
}