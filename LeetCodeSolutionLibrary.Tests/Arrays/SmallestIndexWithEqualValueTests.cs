using LeetCodeLibrary.Arrays;
using Xunit;

namespace LeetCodeLibrary.Tests.Arrays
{
    public class SmallestIndexWithEqualValueTests
    {
        [Theory]
        [InlineData(new int[] { 0, 1, 2 }, 0)]
        [InlineData(new int[] { 4, 3, 2, 1 }, 2)]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, -1)]
        [InlineData(new int[] { 2, 1, 3, 5, 2 }, 1)]
        public void SmallestEqual_ShouldReturnExpectedIndex(int[] nums, int expected)
        {
            //Arrange
            SmallestIndexWithEqualValue solution = new SmallestIndexWithEqualValue();
            int actual;

            //Act
            actual = solution.SmallestEqual(nums);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
