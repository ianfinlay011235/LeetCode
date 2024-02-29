using LeetCodeLibrary.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeLibrary.Tests.Arrays
{
    public class LongestPalindromicSubstringTests
    {
        [Theory]
        [InlineData("babad", new string[] { "bab", "aba" })]
        [InlineData("cbbd", new string[] { "bb" })]
        [InlineData("a", new string[] { "a" })]
        [InlineData("ac", new string[] { "a", "c" })]
        public void LongestPalindrome_ShouldReturnExpectedValue(string s, string[] expected)
        {
            //Arrange
            LongestPalindromicSubstring solution = new LongestPalindromicSubstring();
            string actual;

            //Act
            actual = solution.LongestPalindrome(s);

            //Assert
            bool isFound = false;
            foreach (var str in expected)
            {
                if (str == actual)
                {
                    isFound = true;
                }
            }
            Assert.True(isFound);
        }
    }
}
