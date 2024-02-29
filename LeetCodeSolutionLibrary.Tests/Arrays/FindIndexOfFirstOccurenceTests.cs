using LeetCodeSolutionLibrary.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Strings
{
    public class FindIndexOfFirstOccurenceTests
    {
        [Theory]
        [InlineData(0, "sadbutsad", "sad")]
        [InlineData(-1, "leetcode", "leeto")]
        public void StrStr_ShouldReturnExpectedValue(int expected, string haystack, string needle)
        {
            //Arrange
            FindIndexOfFirstOccurence solution = new FindIndexOfFirstOccurence();
            int actual;

            //Act
            actual = solution.StrStr(haystack, needle);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
