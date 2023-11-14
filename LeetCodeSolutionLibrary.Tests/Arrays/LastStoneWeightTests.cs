using LeetCodeSolutionLibrary.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Arrays
{
    public class LastStoneWeightTests
    {
        [Theory]
        [InlineData(1, new int[] { 2, 7, 4, 1, 8, 1 })]
        [InlineData(1, new int[] { 1 })]
        [InlineData(3, new int[] { 7, 6, 7, 6, 9 })]
        public void LastWeight_ShouldReturnExpectedValue(int expected, int[] stones)
        {
            //Arrange
            LastStoneWeight solution = new LastStoneWeight();
            int actual;

            //Act
            actual = solution.LastWeight(stones);


            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
