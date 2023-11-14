using LeetCodeSolutionLibrary.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Arrays
{
    public class SignOfTheProductOfAnArrayTests
    {
        [Theory]
        [InlineData(1, new int[] { -1, -2, -3, -4, 3, 2, 1 })]
        [InlineData(0, new int[] { 1, 5, 0, 2, -3 })]
        [InlineData(-1, new int[] { -1, 1, -1, 1, -1 })]
        public void ArraySign_ShouldReturnExpectedValue(int expected, int[] nums)
        {
            //Arrange
            SignOfTheProductOfAnArray solution = new SignOfTheProductOfAnArray();
            int actual;

            //Act
            actual = solution.ArraySign(nums);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
