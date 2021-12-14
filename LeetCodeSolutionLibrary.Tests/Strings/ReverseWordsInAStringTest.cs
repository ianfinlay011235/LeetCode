using LeetCodeLibrary.Strings;
using Xunit;

namespace LeetCodeLibrary.Tests.Strings
{
    public class ReverseWordsInAStringTest
    {
        [Theory]
        [InlineData("the sky is blue", "blue is sky the")]
        [InlineData("  hello world  ", "world hello")]
        [InlineData("a good   example", "example good a")]
        [InlineData("  Bob    Loves  Alice   ", "Alice Loves Bob")]
        [InlineData("Alice does not even like bob", "bob like even not does Alice")]
        public void ReverseWords_ShouldReturnExpectedString(string input, string expected)
        {
            //Arrange
            ReverseWordsInAString rw = new ReverseWordsInAString();

            //Act
            string actual = rw.ReverseWords(input);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
