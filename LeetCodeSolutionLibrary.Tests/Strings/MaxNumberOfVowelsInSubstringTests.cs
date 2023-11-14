using LeetCodeSolutionLibrary.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Strings
{
    public class MaxNumberOfVowelsInSubstringTests
    {
        [Theory]
        [InlineData(3, "abciiidef", 3)]
        [InlineData(2, "aeiou", 2)]
        [InlineData(2, "leetcode", 3)]
        public void MaxVowels_ShouldReturnExpectedValue(int expected, string s, int k)
        {
            //Arrange
            MaxNumberOfVowelsInSubstring solution = new MaxNumberOfVowelsInSubstring();
            int actual;

            //Act
            actual = solution.MaxVowels(s, k);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
