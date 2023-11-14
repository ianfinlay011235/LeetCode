using LeetCodeSolutionLibrary.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Arrays
{
    public class MaximumSubsequenceScoreTests
    {
        [Theory]
        [InlineData(12, new int[] { 1, 3, 3, 2 }, new int[] { 2, 1, 3, 4 }, 3)]
        [InlineData(30, new int[] { 4, 2, 3, 1, 1 }, new int[] { 7, 5, 10, 9, 6 }, 1)]
        public void MaxScore_ShouldReturnExpectedValue(long expected, int[] nums1, int[] nums2, int k)
        {
            //Arrange
            MaximumSubsequenceScore obj = new MaximumSubsequenceScore();
            long actual;

            //Act
            actual = obj.MaxScore(nums1, nums2, k);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
