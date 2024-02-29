using LeetCodeSolutionLibrary.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Strings
{
    public class LongestSubstringWithoutRepeatingCharactersTests
    {
        [Theory]
        [InlineData(3, "abcabcbb")]
        [InlineData(1, "bbbbb")]
        [InlineData(3, "pwwkew")]
        [InlineData(1, " ")]
        public void LengthOfLongestSubstring_ShouldReturnExpectedValue(int expected, string s)
        {
            //Arrange
            LongestSubstringWithoutRepeatingCharacters solution = new LongestSubstringWithoutRepeatingCharacters();
            int actual;

            //Act
            actual = solution.LengthOfLongestSubstring(s);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
