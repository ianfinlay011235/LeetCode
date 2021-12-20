using LeetCodeLibrary.Paths;
using Xunit;

namespace LeetCodeLibrary.Tests.Paths
{
    public class UniquePathsTests
    {
        [Theory]
        [InlineData(3, 7, 28)]
        [InlineData(3, 2, 3)]
        [InlineData(7, 3, 28)]
        [InlineData(3, 3, 6)]
        public void GetUniquePaths_ShouldReturnExpectedValue(int m, int n, int expected)
        {
            //Arrange
            UniquePaths solution = new UniquePaths();
            int actual;

            //Act
            actual = solution.GetUniquePaths(m, n);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
