using LeetCodeLibrary.Sorting;
using Xunit;

namespace LeetCodeLibrary.Tests.Sorting
{
    public class ColorSorterTests
    {
        [Theory]
        [InlineData(new int[] { 2, 0, 2, 1, 1, 0 }, new int[] { 0, 0, 1, 1, 2, 2 })]
        [InlineData(new int[] { 2, 0, 1 }, new int[] { 0, 1, 2 })]
        [InlineData(new int[] { 0 }, new int[] { 0 })]
        [InlineData(new int[] { 1 }, new int[] { 1 })]
        public void SortColors_ShouldReturnExpectedSort(int[] actual, int[] expected)
        {
            //Arrange
            ColorSorter cs = new ColorSorter();

            //Act
            cs.SortColors(actual);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
