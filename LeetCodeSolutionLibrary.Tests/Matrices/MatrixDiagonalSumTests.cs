using LeetCodeSolutionLibrary.Matrices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Matrices
{
    public class MatrixDiagonalSumTests
    {
        [Theory]
        [ClassData(typeof(MatrixDiagonalSumTestData))]
        public void DiagonalSum_ShouldReturnExpectedValue(int expected, int[][] mat)
        {
            //Arrange
            MatrixDiagonalSum solution = new MatrixDiagonalSum();
            int actual;

            //Act
            actual = solution.DiagonalSum(mat);

            //Assert
            Assert.Equal(expected, actual);
        }
    }

    public class MatrixDiagonalSumTestData : TheoryData<int, int[][]>
    {
        public MatrixDiagonalSumTestData()
        {
            Add(25, new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } });
            Add(8, new int[][] { new int[] { 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1 } });
            Add(5, new int[][] { new int[] { 5 } });
        }
    }
}
