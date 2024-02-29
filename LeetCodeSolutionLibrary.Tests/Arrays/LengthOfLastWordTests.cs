using LeetCodeSolutionLibrary.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Strings
{
    public class LengthOfLastWordTests
    {
        [Theory]
        [InlineData(5, "Hello World")]
        [InlineData(4, "   fly me   to   the moon  ")]
        [InlineData(6, "luffy is still joyboy")]
        [InlineData(1, "a ")]
        public void LengthOfLastWord_ShouldReturnExpectedValue(int expected, string s)
        {
            //Arrange
            LengthOfLastWord solution = new LengthOfLastWord();
            int actual;

            //Act
            actual = solution.LastWordLength(s);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
