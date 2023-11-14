using LeetCodeSolutionLibrary.Paths;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Paths
{
    public class ReorderRoutesOfDirectedGraphTests
    {
        //[Theory]
        //[InlineData(3, 6, new int[] { 0, 1 }, new int[] { 1, 3 }, new int[] { 2, 3 }, new int[] { 4, 0 }, new int[] { 4, 5 })]
        //[InlineData(2, 5, new int[] { 1, 0 }, new int[] { 1, 2 }, new int[] { 3, 2 }, new int[] { 3, 4 })]
        //[InlineData(0, 3, new int[] { 1, 0 }, new int[] { 2, 0 })]
        public void MinReorder_ShouldReturnExpectedValue(int expected, int n, params int[][] connections)
        {
            //Arrange
            ReorderRoutesOfDirectedGraph solution = new ReorderRoutesOfDirectedGraph();
            int actual;

            //Act
            actual = solution.MinReorder(n, connections);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
