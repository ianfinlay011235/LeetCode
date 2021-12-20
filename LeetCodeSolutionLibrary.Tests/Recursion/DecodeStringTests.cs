using LeetCodeSolutionLibrary.Recursion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Recursion
{
    public class DecodeStringTests
    {
        [Theory]
        [InlineData("3[a]2[bc]", "aaabcbc")]
        [InlineData("3[a2[c]]", "accaccacc")]
        [InlineData("2[abc]3[cd]ef", "abcabccdcdcdef")]
        [InlineData("abc3[cd]xyz", "abccdcdcdxyz")]
        public void Decode_ShouldReturnExpectedValue(string s, string expected)
        {
            //Arrange
            DecodeString solution = new DecodeString();
            string actual;

            //Act
            actual = solution.Decode(s);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
