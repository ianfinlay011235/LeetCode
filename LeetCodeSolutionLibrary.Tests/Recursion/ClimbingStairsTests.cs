using LeetCodeSolutionLibrary.Recursion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Recursion
{
    public class ClimbingStairsTests
    {
        [Theory]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        public void ClimbStairs_ShouldReturnExpectedValue(int n, int expected)
        {
            //Arrange
            ClimbingStairs solution = new ClimbingStairs();
            int actual;

            //Act
            actual = solution.ClimbStairs(n);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
