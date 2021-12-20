using LeetCodeLibrary.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeLibrary.Tests.Strings
{
    public class AddBinaryTests
    {
        [Theory]
        [InlineData("11", "1", "100")]
        [InlineData("1010", "1011", "10101")]
        [InlineData("1", "1", "10")]
        [InlineData("0", "0", "0")]
        public void Add_ShouldReturnExpectedValue(string a, string b, string expected)
        {
            //Arrange
            AddBinary solution = new AddBinary();
            string actual;

            //Act
            actual = solution.Add(a, b);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
