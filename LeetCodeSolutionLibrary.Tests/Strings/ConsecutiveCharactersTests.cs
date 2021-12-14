using LeetCodeLibrary.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeLibrary.Tests.Strings
{
    public class ConsecutiveCharactersTests
    {
        [Theory]
        [InlineData("leetcode", 2)]
        [InlineData("abbcccddddeeeeedcba", 5)]
        [InlineData("triplepillooooow", 5)]
        [InlineData("hooraaaaaaaaaaay", 11)]
        [InlineData("tourist", 1)]
        public void MaxPower_ShouldReturnExpectedValue(string s, int expected)
        {
            //Arrange
            ConsecutiveCharacters solution = new ConsecutiveCharacters();
            int actual;

            //Act
            actual = solution.MaxPower(s);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
