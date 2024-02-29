using LeetCodeLibrary.Arrays;
using Xunit;

namespace LeetCodeLibrary.Tests.Arrays
{
    public class ImplementStrStrTests
    {
        [Theory]
        [InlineData("hello", "ll", 2)]
        [InlineData("aaaaa", "bba", -1)]
        [InlineData("", "", 0)]
        [InlineData("mississippi", "issipi", -1)]
        public void StrStr_ShouldReturnExpectedValue(string haystack, string needle, int expected)
        {
            //Arrange
            ImplementStrStr solution = new ImplementStrStr();
            int actual;

            //Act
            actual = solution.StrStr(haystack, needle);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
