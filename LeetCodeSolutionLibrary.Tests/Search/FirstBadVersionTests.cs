using LeetCodeLibrary.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeLibrary.Tests.Search
{
    public class FirstBadVersionTests
    {
        [Theory]
        [InlineData(5, 4)]
        [InlineData(1, 1)]
        public void FindBadVersion_ShouldReturnExpectedValue(int n, int expected)
        {
            //Arrange
            FirstBadVersion solution = new FirstBadVersion(expected);
            int actual;

            //Act
            actual = solution.FindBadVersion(n);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
