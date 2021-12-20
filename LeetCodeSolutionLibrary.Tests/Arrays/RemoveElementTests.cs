using LeetCodeLibrary.Arrays;
using Xunit;

namespace LeetCodeLibrary.Tests.Arrays
{
    public class RemoveElementTests
    {
        [Theory]
        [InlineData(new int[] { 3, 2, 2, 3 }, 3, 2)]
        [InlineData(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5)]
        [InlineData(new int[] { 1 }, 1, 0)]
        public void RemoveElement_ShouldReturnExpectedValue(int[] nums, int val, int expected)
        {
            //Arrange
            RemoveElement re = new RemoveElement();

            //Act
            int actual = re.Remove(nums, val);

            //Assert
            Assert.Equal(expected, actual);
            for (int i = 0; i < actual; i++) Assert.NotEqual(val, nums[i]);
        }
    }
}