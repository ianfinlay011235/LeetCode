using LeetCodeLibrary.Arrays;
using Xunit;

namespace LeetCodeLibrary.Tests.Arrays
{
    public class NumberOfValidWordsInASentenceTests
    {
        [Theory]
        [InlineData("cat and  dog", 3)]
        [InlineData("!this  1-s b8d!", 0)]
        [InlineData("alice and  bob are playing stone-game10", 5)]
        [InlineData("he bought 2 pencils, 3 erasers, and 1  pencil-sharpener.", 6)]
        public void CountValidWords_ShouldReturnExpectedValue(string sentence, int expected)
        {
            //Arrange
            NumberOfValidWordsInASentence solution = new NumberOfValidWordsInASentence();
            int actual;

            //Act
            actual = solution.CountValidWords(sentence);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
