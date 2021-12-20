using LeetCodeLibrary.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeLibrary.Tests.Strings
{
    public class ZigZagConversionTests
    {
        [Theory]
        [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
        [InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
        [InlineData("A", 1, "A")]
        public void Convert_ShouldReturnExpectedString(string s, int numRows, string expected)
        {
            //Arrange
            ZigZagConversion solution = new ZigZagConversion();
            string actual;

            //Act
            actual = solution.Convert(s, numRows);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
