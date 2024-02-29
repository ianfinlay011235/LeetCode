using LeetCodeLibrary.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeLibrary.Tests.Arrays
{
    public class RotateArrayTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3, new int[] { 5, 6, 7, 1, 2, 3, 4 })]
        [InlineData(new int[] { -1, -100, 3, 99 }, 2, new int[] { 3, 99, -1, -100 })]
        [InlineData(new int[] { 1, 2 }, 1, new int[] { 2, 1 })]
        [InlineData(new int[] { 1, 2, 3 }, 4, new int[] { 3, 1, 2 })]
        public void Rotate_ShouldRotateArrayByKSteps(int[] actual, int k, int[] expected)
        {
            //Arrange
            RotateArray solution = new RotateArray();

            //Act
            solution.Rotate(actual, k);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
