using LeetCodeLibrary.Paths;
using LeetCodeSolutionLibrary.Paths;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Paths
{
    public class MinimumScorePathTests
    {
        [Theory]
        [InlineData(5, 4, new int[] { 1, 2, 9 }, new int[] { 2, 3, 6 }, new int[] { 2, 4, 5 }, new int[] { 1, 4, 7 })]
        [InlineData(2, 4, new int[] { 1, 2, 2 }, new int[] { 1, 3, 4 }, new int[] { 3, 4, 7 })]
        [InlineData(2150, 14, new int[] { 2, 9, 2308}, new int[] { 2, 5, 2150}, new int[] { 12, 3, 4944}, 
            new int[] { 13, 5, 5462}, new int[] { 2, 10, 2187}, new int[] { 2, 12, 8132}, new int[] { 2, 13, 3666},
             new int[] { 4, 14, 3019}, new int[] { 2, 4, 6759}, new int[] { 2, 14, 9869}, new int[] { 1, 10, 8147},
             new int[] { 3, 4, 7971}, new int[] { 9, 13, 8026}, new int[] { 5, 12, 9982}, new int[] { 10, 9, 6459})]
        public void MinScore_ShouldReturnExpectedValues(int expected, int n, params int[][] roads)
        {
            //Arrange
            MinimumScorePath solution = new MinimumScorePath();
            int actual;

            //Act
            actual = solution.MinScore(n, roads);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
