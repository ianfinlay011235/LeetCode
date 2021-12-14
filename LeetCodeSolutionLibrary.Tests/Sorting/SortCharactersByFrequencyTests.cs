using LeetCodeLibrary.Sorting;
using Xunit;

namespace LeetCodeLibrary.Tests.Sorting
{
    public class SortCharactersByFrequencyTests
    {
        [Theory]
        [InlineData("tree", new string[] { "eert", "eetr" })]
        [InlineData("cccaaa", new string[] { "cccaaa", "aaaccc" })]
        [InlineData("Aabb", new string[] { "bbAa", "bbaA" })]
        public void FrequencySort_ShouldReturnExpectedValue(string input, string[] expected)
        {
            //Arrange
            SortCharactersByFrequency sorter = new SortCharactersByFrequency();

            //Act
            string actual = sorter.FrequencySort(input);

            //Assert
            Assert.Contains(actual, expected);
        }
    }
}
