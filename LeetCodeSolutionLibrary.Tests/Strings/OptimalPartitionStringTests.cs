using LeetCodeSolutionLibrary.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Strings
{
    public class OptimalPartitionStringTests
    {
        [Theory]
        [InlineData(4, "abacaba")]
        [InlineData(6, "ssssss")]
        public void PartitionString_ShouldReturnExpectedValue(int expected, string s)
        {
            //Arrange
            OptimalPartitionString solution = new OptimalPartitionString();
            int actual;

            //Act
            actual = solution.PartitionString(s);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
