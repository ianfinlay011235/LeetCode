using LeetCodeLibrary.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeLibrary.Tests.Sorting
{
    public class MergeSortedArrayTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3, new int[] { 1, 2, 2, 3, 5, 6 })]
        [InlineData(new int[] { 1 }, 1, new int[] {  }, 0, new int[] { 1 })]
        [InlineData(new int[] { 0 }, 0, new int[] { 1 }, 1, new int[] { 1 })]
        public void Merge_ShouldMergeBothArraysIntoFirstArray(int[] nums1, int m, int[] nums2, int n, int[] expected)
        {
            //Arrange
            MergeSortedArray solution = new MergeSortedArray();

            //Act
            solution.Merge(nums1, m, nums2, n);

            //Assert
            Assert.Equal(expected, nums1);
        }
    }
}
