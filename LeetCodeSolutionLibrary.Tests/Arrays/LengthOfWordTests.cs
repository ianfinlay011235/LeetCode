using LeetCodeLibrary.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeLibrary.Tests.Arrays
{
    public class LengthOfWordTests
    {
        [Theory]
        [InlineData("Hello World", 5)]
        [InlineData("   fly me   to   the moon  ", 4)]
        [InlineData("luffy is still joyboy", 6)]
        public void LengthOfLastWord_ShouldReturnExpectedValue(string s, int expected)
        {
            //Arrange
            LengthOfWord solution = new LengthOfWord();
            int actual;

            //Act
            actual = solution.LengthOfLastWord(s);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
