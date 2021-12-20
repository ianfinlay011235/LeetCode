using LeetCodeLibrary.Sums;
using Xunit;

namespace LeetCodeLibrary.Tests.Sums
{
    public class ArrangingCoinsTests
    {
        [Theory]
        [InlineData(5, 2)]
        [InlineData(8, 3)]
        [InlineData(1, 1)]
        [InlineData(3, 2)]
        public void ArrangeCoins_ShouldReturnExpectedValue(int input, int expected)
        {
            //Arrange
            ArrangingCoins solution = new ArrangingCoins();
            int actual;

            //Act
            actual = solution.ArrangeCoins(input);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
