using LeetCodeSolutionLibrary.Matrices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Matrices
{
    public class SpiralMatrix2Tests
    {
        [Theory]
        [ClassData(typeof(SpiralMatrix2DataGenerator))]
        public void GenerateMatrix_ShouldReturnExpectedMatrix(int[][] expected, int n)
        {
            //Arrange
            SpiralMatrix2 solution = new SpiralMatrix2();
            int[][] actual;

            //Act
            actual = solution.GenerateMatrix(n);

            //Assert
            Assert.Equal(expected, actual);
        }
    }

    public class SpiralMatrix2DataGenerator : TheoryData<int[][], int>
    {
        public SpiralMatrix2DataGenerator()
        {
            Add(new int[][] { new int[] { 1, 2, 3 }, new int[] { 8, 9, 4 }, new int[] { 7, 6, 5 } }, 3);
            Add(new int[][] { new int[] { 1 } }, 1);
        }
    }
}
