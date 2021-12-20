using LeetCodeLibrary.Arrays;
using Xunit;

namespace LeetCodeLibrary.Tests.Arrays
{
    public class KthDistinctStringInAnArrayTests
    {
        [Theory]
        [InlineData(new string[] { "d", "b", "c", "b", "c", "a" }, 2, "a")]
        [InlineData(new string[] { "aaa", "aa", "a" }, 1, "aaa")]
        [InlineData(new string[] { "a", "b", "a" }, 3, "")]
        public void KthDistinct_ShouldReturnExpectedString(string[] arr, int k, string expected)
        {
            //Arrange
            KthDistinctStringInAnArray solution = new KthDistinctStringInAnArray();
            string actual;

            //Act
            actual = solution.KthDistinct(arr, k);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
