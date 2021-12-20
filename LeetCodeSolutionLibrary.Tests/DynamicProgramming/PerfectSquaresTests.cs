using LeetCodeLibrary.DynamicProgramming;
using Xunit;

namespace LeetCodeLibrary.Tests.DynamicProgramming
{
    public class PerfectSquaresTests
    {
        [Theory]
        [InlineData(12, 3)]
        [InlineData(13, 2)]
        //TODO: Add more test cases
        public void PerfectSquares_ShouldReturnExpectedValues(int input, int expected)
        {
            //Arrange
            PerfectSquares perfectSquares = new PerfectSquares();

            //Act
            int actual = perfectSquares.NumSquares(input);

            //Assert
            Assert.Equal(expected, actual);
        } 
    }
}
