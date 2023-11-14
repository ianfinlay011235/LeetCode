using LeetCodeSolutionLibrary.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Search
{
    public class NumberOfClosedIslandsTests
    {
        [Theory]
        [InlineData(2, 
            new int[] { 1, 1, 1, 1, 1, 1, 1, 0 }, 
            new int[] { 1, 0, 0, 0, 0, 1, 1, 0 }, 
            new int[] { 1, 0, 1, 0, 1, 1, 1, 0 }, 
            new int[] { 1, 0, 0, 0, 0, 1, 0, 1 }, 
            new int[] { 1, 1, 1, 1, 1, 1, 1, 0 })]
        [InlineData(1, 
            new int[] { 0, 0, 1, 0, 0 }, 
            new int[] { 0, 1, 0, 1, 0 }, 
            new int[] { 0, 1, 1, 1, 0 })]
        [InlineData(2, 
            new int[] { 1, 1, 1, 1, 1, 1, 1 }, 
            new int[] { 1, 0, 0, 0, 0, 0, 1 }, 
            new int[] { 1, 0, 1, 1, 1, 0, 1 }, 
            new int[] { 1, 0, 1, 0, 1, 0, 1 }, 
            new int[] { 1, 0, 1, 1, 1, 0, 1 }, 
            new int[] { 1, 0, 0, 0, 0, 0, 1 }, 
            new int[] { 1, 1, 1, 1, 1, 1, 1 })]
        public void ClosedIsland_ShouldReturnExpectedValue(int expected, params int[][] grid)
        {
            //Arrange
            NumberOfClosedIslands solution = new NumberOfClosedIslands();
            int actual;

            //Act
            actual = solution.ClosedIslands(grid);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
