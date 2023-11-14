using LeetCodeSolutionLibrary.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Search
{
    public class ShortestPathInBinaryMatrixTests
    {
        [Theory]
        [ClassData(typeof(ShortestPathInBinaryMatrixDataGenerator))]
        public void ShortestPathBinaryMatrix_ShouldReturnExpectedValue(int expected, int[][] grid)
        {
            //Arrange
            ShortestPathInBinaryMatrix obj = new ShortestPathInBinaryMatrix();
            int actual;

            //Act
            actual = obj.ShortestPathBinaryMatrix(grid);

            //Assert
            Assert.Equal(expected, actual);
        }
    }

    public class ShortestPathInBinaryMatrixDataGenerator : TheoryData<int, int[][]>
    {
        public ShortestPathInBinaryMatrixDataGenerator()
        {
            Add(2, new int[][] { new int[] { 0, 1 }, new int[] { 1, 0 } });
            Add(4, new int[][] { new int[] { 0, 0, 0 }, new int[] { 1, 1, 0 }, new int[] { 1, 1, 0 } });
            Add(-1, new int[][] { new int[] { 1, 0, 0 }, new int[] { 1, 1, 0 }, new int[] { 1, 1, 0 } });
            Add(14, new int[][] { new int[] { 0, 1, 1, 0, 0, 0 }, new int[] { 0, 1, 0, 1, 1, 0 }, 
                new int[] { 0, 1, 1, 0, 1, 0 }, new int[] { 0, 0, 0, 1, 1, 0 }, new int[] { 1, 1, 1, 1, 1, 0 }, 
                new int[] { 1, 1, 1, 1, 1, 0 } });
        }
    }
}
