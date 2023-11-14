using LeetCodeSolutionLibrary.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Strings
{
    public class RomanToIntegerTests
    {
        [Theory]
        [InlineData(3, "III")]
        [InlineData(58, "LVIII")]
        [InlineData(1994, "MCMXCIV")]
        public void RomanToInt(int expected, string s)
        {
            //Arrange
            RomanToInteger solution = new RomanToInteger();
            int actual;

            //Act
            actual = solution.RomanToInt(s);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
