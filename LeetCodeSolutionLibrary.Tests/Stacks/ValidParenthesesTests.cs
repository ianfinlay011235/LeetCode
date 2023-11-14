using LeetCodeSolutionLibrary.Stacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Stacks
{
    public class ValidParenthesesTests
    {
        [Theory]
        [InlineData(true, "()")]
        [InlineData(true, "()[]{}")]
        [InlineData(false, "(]")]
        public void IsValid_ShouldReturnExpectedValue(bool expected, string s)
        {
            //Arrange
            ValidParentheses solution = new ValidParentheses();
            bool actual;

            //Act
            actual = solution.IsValid(s);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
