using LeetCodeSolutionLibrary.GameTheory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.GameTheory
{
    public class New21GameTests
    {
        [Theory]
        [InlineData(1, 10, 1, 10)]
        [InlineData(.6, 6, 1, 10)]
        [InlineData(.73278, 21, 17, 10)]
        public void NewGame_ShouldReturnExpectedValue(double expected, int n, int k, int maxPts)
        {
            //Arrange
            New21Game obj = new New21Game();
            double actual;

            //Act
            actual = obj.NewGame(n, k, maxPts);

            //Assert
            Assert.True(actual >= expected - 0.00001 && actual <= expected + 0.00001);
        }
    }
}
