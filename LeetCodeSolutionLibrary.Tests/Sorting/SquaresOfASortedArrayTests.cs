using LeetCodeLibrary.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeLibrary.Tests.Sorting
{
    public class SquaresOfASortedArrayTests
    {
        [Theory]
        [InlineData(new int[] { -4, -1, 0, 3, 10 }, new int[] { 0, 1, 9, 16, 100 })]
        [InlineData(new int[] { -7, -3, 2, 3, 11 }, new int[] { 4, 9, 9, 49, 121 })]
        public void SortedSquares_ShouldReturnExpectedArray(int[] nums, int[] expected)
        {
            //Arrange
            SquaresOfASortedArray solution = new SquaresOfASortedArray();
            int[] actual;

            //Act
            actual = solution.SortedSquares(nums);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
