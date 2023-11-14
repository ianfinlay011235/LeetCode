using LeetCodeSolutionLibrary.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Mathematics
{
    public class SqrtTests
    {
        [Theory]
        [InlineData(4, 2)]
        [InlineData(8, 2)]
        public void MySqrt_ShouldReturnExpectedValue(int input, int expected)
        {
            //Arrange
            Sqrt solution = new Sqrt();
            int actual;

            //Act
            actual = solution.MySqrt(input);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
