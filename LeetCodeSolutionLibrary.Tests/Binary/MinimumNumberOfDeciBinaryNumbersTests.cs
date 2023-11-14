using LeetCodeSolutionLibrary.Binary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Binary
{
    public class MinimumNumberOfDeciBinaryNumbersTests
    {
        [Theory]
        [InlineData(3, "32")]
        [InlineData(8, "82734")]
        [InlineData(9, "27346209830709182346")]
        public void MinPartitions_ShouldReturnExpectedValue(int expected, string n)
        {
            //Arrange
            MinimumNumberOfDeciBinaryNumbers solution = new MinimumNumberOfDeciBinaryNumbers();
            int actual;

            //Act
            actual = solution.MinPartitions(n);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
