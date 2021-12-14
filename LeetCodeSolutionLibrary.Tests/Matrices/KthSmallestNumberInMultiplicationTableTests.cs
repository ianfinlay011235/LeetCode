using LeetCodeLibrary.Matrices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeLibrary.Tests.Matrices
{
    public class KthSmallestNumberInMultiplicationTableTests
    {
        [Theory]
        [InlineData(3, 3, 5, 3)]
        [InlineData(2, 3, 6, 6)]
        public void FindKthNumber_ShouldReturnExpectedValue(int m, int n, int k, int expected)
        {
            //Arragne
            KthSmallestNumberInMultiplicationTable solution = new KthSmallestNumberInMultiplicationTable();
            int actual;

            //Act
            actual = solution.FindKthNumber(m, n, k);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
