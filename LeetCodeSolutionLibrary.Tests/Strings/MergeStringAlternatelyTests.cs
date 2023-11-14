using LeetCodeSolutionLibrary.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Strings
{
    public class MergeStringAlternatelyTests
    {
        [Theory]
        [InlineData("apbqcr", "abc", "pqr")]
        [InlineData("apbqrs", "ab", "pqrs")]
        [InlineData("apbqcd", "abcd", "pq")]
        public void MergeAlternately_ShouldReturnExpectedValue(string expected, string word1, string word2)
        {
            //Arrange
            MergeStringAlternately solution = new MergeStringAlternately();
            string actual;

            //Act
            actual = solution.MergeAlternately(word1, word2);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
