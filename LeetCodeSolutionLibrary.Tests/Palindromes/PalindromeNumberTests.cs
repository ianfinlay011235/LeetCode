using LeetCodeSolutionLibrary.Palindromes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Palindromes
{
    public class PalindromeNumberTests
    {
        [Theory]
        [InlineData(true, 121)]
        [InlineData(false, -121)]
        [InlineData(false, 10)]
        public void IsPalindrome_ShouldReturnExpectedValue(bool expected, int x)
        {
            //Arrange
            PalindromeNumber solution = new PalindromeNumber();
            bool actual;

            //Act
            actual = solution.IsPalindrome(x);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
