using LeetCodeLibrary.Sums;
using Xunit;

namespace LeetCodeLibrary.Tests.Sums
{
    public class MinValueToGetPosSumTests
    {
        [Theory]
        [InlineData(new int[] { -3, 2, -3, 4, 2 }, 5)]
        [InlineData(new int[] { 1, 2 }, 1)]
        [InlineData(new int[] { 1, -2, -3 }, 5)]
        public void MinStartValue_ShouldReturnExpectedValue(int[] nums, int expected)
        {
            //Arrange
            MinValueToGetPosSum solution = new MinValueToGetPosSum();
            int actual;

            //Act
            actual = solution.MinStartValue(nums);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
