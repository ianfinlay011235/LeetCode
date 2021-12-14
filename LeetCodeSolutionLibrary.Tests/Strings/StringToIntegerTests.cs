using LeetCodeLibrary.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeLibrary.Tests.Strings
{
    public class StringToIntegerTests
    {
        [Theory]
        [InlineData("42", 42)]
        [InlineData("-42", -42)]
        [InlineData("4193 with words", 4193)]
        [InlineData("words and 987", 0)]
        [InlineData("-91283472332", -2147483648)]
        [InlineData(" ", 0)]
        [InlineData("2147483648", 2147483647)]
        public void MyAtoi_ShouldReturnExpectedValue(string s, int expected)
        {
            //Arrange
            StringToInteger solution = new StringToInteger();
            int actual;

            //Act
            actual = solution.MyAtoi(s);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
