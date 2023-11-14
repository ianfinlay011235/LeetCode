using LeetCodeSolutionLibrary.Paths;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Paths
{
    public class MinimumPathSumTests
    {
        [Theory]
        [InlineData(7, new int[] { 1, 3, 1 }, new int[] { 1, 5, 1 }, new int[] { 4, 2, 1 })]
        [InlineData(12, new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 })]
        public void MinPathSum_ShouldReturnExpectedValue(int expected, params int[][] grid)
        {
            //Arrange
            MinimumPathSum solution = new MinimumPathSum();
            int actual;

            //Act
            actual = solution.MinPathSum(grid);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
