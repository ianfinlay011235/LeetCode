using LeetCodeLibrary.Binary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeLibrary.Tests.Binary
{
    public class HammingDistanceTests
    {
        [Theory]
        [InlineData(1, 4, 2)]
        [InlineData(3, 1, 1)]
        public void GetHammingDistance(int x, int y, int expected)
        {
            //Arrange
            HammingDistance solution = new HammingDistance();
            int actual;

            //Act
            actual = solution.GetHammingDistance(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
