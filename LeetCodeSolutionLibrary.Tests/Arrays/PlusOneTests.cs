using Xunit;
using LeetCodeSolutionLibrary.Arrays;

namespace LeetCodeSolutionLibrary.Tests.Arrays
{
    public class PlusOneTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 4 })]
        [InlineData(new int[] { 4, 3, 2, 1 }, new int[] { 4, 3, 2, 2 })]
        [InlineData(new int[] { 0 }, new int[] { 1 })]
        [InlineData(new int[] { 9 }, new int[] { 1, 0 })]
        [InlineData(new int[] { 8, 9, 9, 9 }, new int[] { 9, 0, 0, 0 })]
        [InlineData(new int[] { 9, 8, 9 }, new int[] { 9, 9, 0 })]
        public void Plus1_ShouldReturnExpectedValue(int[] digits, int[] expected)
        {
            //Arrange
            int[] actual;

            //Act
            actual = PlusOne.Plus1(digits);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
