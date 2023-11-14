using LeetCodeSolutionLibrary.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Arrays
{
    public class RemoveDuplicatesFromSortedArrayTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2 }, new int[] { 1, 1, 2 })]
        [InlineData(new int[] { 0, 1, 2, 3, 4 }, new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 })]
        public void RemoveDuplicates_ShouldReturnExpectedArray(int[] expectedNums, int[] nums)
        {
            //Arrange
            RemoveDuplicatesFromSortedArray solution = new RemoveDuplicatesFromSortedArray();
            int actual;

            //Act
            actual = solution.RemoveDuplicates(nums);

            //Assert
            //Assert acceptance criteria provided by "Custom Judge":
            //https://leetcode.com/problems/remove-duplicates-from-sorted-array/

            Assert.Equal(expectedNums.Length, actual);
            for (int i = 0; i < actual; i++)
            {
                Assert.Equal(expectedNums[i], nums[i]);
            }
        }
    }
}
