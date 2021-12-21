using LeetCodeSolutionLibrary.BitManipulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.BitManipulation
{
    public class PowerOfTwoTests
    {
        [Theory]
        [InlineData(1, true)]
        [InlineData(16, true)]
        [InlineData(3, false)]
        public void IsPowerOfTwo_ShouldReturnExpectedValue(int n, bool expected)
        {
            //Arrange
            PowerOfTwo solution = new PowerOfTwo();
            bool actual;

            //Act
            actual = solution.IsPowerOfTwo(n);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
