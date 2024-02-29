using System;
using LeetCodeSolutionLibrary.DynamicProgramming;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.DynamicProgramming
{
	public class MinimumFallingPathSumTests
	{
		[Theory]
		[ClassData(typeof(MinimumFallingPathSumDataGenerator))]
		public void MinFallingPathSum_ShouldReturnExpectedValue(int expected, int[][] matrix)
		{
			//Arrange
			MinimumFallingPathSum solution = new MinimumFallingPathSum();
			int actual;
			
			//Act
			actual = solution.MinFallingPathSum(matrix);
			
			//Assert
			Assert.Equal(expected, actual);
		}
	}

    public class MinimumFallingPathSumDataGenerator : TheoryData<int, int[][]>
    {
        public MinimumFallingPathSumDataGenerator()
        {
            Add(13, new int[][] { new int[] { 2, 1, 3 }, new int[] { 6, 5, 4 }, new int[] { 7, 8, 9 } });
			Add(-59, new int[][] { new int[] { -19, 57 }, new int[] { -40, -5 } });
        }
    }

}