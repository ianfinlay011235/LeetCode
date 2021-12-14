using LeetCodeLibrary.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeLibrary.Tests.Arrays
{
    public class JumpGame3Tests
    {
        [Theory]
        [InlineData(new int[] { 4, 2, 3, 0, 3, 1, 2 }, 5, true)]
        [InlineData(new int[] { 4, 2, 3, 0, 3, 1, 2 }, 0, true)]
        [InlineData(new int[] { 3, 0, 2, 1, 2 }, 2, false)]
        public void CanReach_ShouldReturnExpectedValue(int[] arr, int start, bool expected)
        {
            //Arrange
            JumpGame3 solution = new JumpGame3();
            bool actual;

            //Act
            actual = solution.CanReach(arr, start);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
