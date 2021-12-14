using LeetCodeLibrary.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeLibrary.Tests.Search
{
    public class BinarySearchTests
    {
        [Theory]
        [InlineData(new int[] { -1, 0, 3, 5, 9, 12 }, 9, 4)]
        [InlineData(new int[] { -1, 0, 3, 5, 9, 12 }, 2, -1)]
        [InlineData(new int[] { 5 }, 5, 0)]
        public void Search_ShouldReturnExpectedValue(int[] nums, int target, int expected)
        {
            //Arrange
            BinarySearch solution = new BinarySearch();
            int actual;

            //Act
            actual = solution.Search(nums, target);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
