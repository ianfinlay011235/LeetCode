using LeetCodeSolutionLibrary.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Arrays
{
    public class MinimizeMaximumOfArrayTests
    {
        [Theory]
        [InlineData(5, new int[] { 3, 7, 1, 6 })]
        [InlineData(10, new int[] { 10, 1 })]
        public void MinimizeArrayValue_ShouldReturnExpectedValue(int expected, int[] nums)
        {
            //Arrange
            MinimizeMaximumOfArray solution = new MinimizeMaximumOfArray();
            int actual;

            //Act
            actual = solution.MinimizeArrayValue(nums);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
