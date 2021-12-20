using LeetCodeLibrary.Sums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeLibrary.Tests.Sums
{
    public class MaximumSubarrayTests
    {
        [Theory]
        [InlineData(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6)]
        [InlineData(new int[] { 1 }, 1)]
        [InlineData(new int[] { 5, 4, -1, 7, 8 }, 23)]
        public void MaxSubArray_ShouldReturnExpectedInt(int[] nums, int expected)
        {
            //Arrange
            MaximumSubarray solution = new MaximumSubarray();
            int actual;

            //Act
            actual = solution.MaxSubArray(nums);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
