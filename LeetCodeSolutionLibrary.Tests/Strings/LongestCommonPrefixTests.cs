using LeetCodeSolutionLibrary.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Strings
{
    public class LongestCommonPrefixTests
    {
        [Theory]
        [InlineData("fl", new string[] { "flower", "flow", "flight" })]
        [InlineData("", new string[] { "dog", "racecar", "car" })]
        public void LongestCommonPref_ShouldReturnExpectedValue(string expected, string[] strs)
        {
            //Arrange
            LongestCommonPrefix solution = new LongestCommonPrefix();
            string actual;

            //Act
            actual = solution.LongestCommonPref(strs);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
