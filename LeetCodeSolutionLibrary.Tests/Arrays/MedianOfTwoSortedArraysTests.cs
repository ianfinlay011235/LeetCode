using LeetCodeLibrary.Arrays;
using Xunit;

namespace LeetCodeLibrary.Tests.Arrays
{
    public class MedianOfTwoSortedArraysTests
    {
        [Theory]
        [InlineData(new int[] { 1, 3 }, new int[] { 2 }, 2.0)]
        [InlineData(new int[] { 1, 2 }, new int[] { 3, 4 }, 2.5)]
        [InlineData(new int[] { 0, 0 }, new int[] { 0, 0 }, 0)]
        [InlineData(new int[] { }, new int[] { 1 }, 1)]
        [InlineData(new int[] { 2 }, new int[] { }, 2)]
        public void FindMedianSortedArrays_ShouldReturnExpectedValue(int[] nums1, int[] nums2, double expected)
        {
            //Arrange
            MedianOfTwoSortedArrays solution = new MedianOfTwoSortedArrays();
            double actual;

            //Act
            actual = solution.FindMedianSortedArrays(nums1, nums2);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
