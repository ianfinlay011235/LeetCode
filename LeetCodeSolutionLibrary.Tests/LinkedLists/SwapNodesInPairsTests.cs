using LeetCodeLibrary.DataStructures.LinkedList;
using LeetCodeSolutionLibrary.LinkedLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.LinkedLists
{
    public class SwapNodesInPairsTests
    {
        [Theory]
        [InlineData(new int[] { 2, 1, 4, 3 }, new int[] { 1, 2, 3, 4 })]
        [InlineData(new int[] { }, new int[] { })]
        [InlineData(new int[] { 1 }, new int[] { 1 })]
        public void SwapPairs_ShouldReturnExpectedList(int[] expected, int[] input)
        {
            //Arrange
            SwapNodesInPairs solution = new SwapNodesInPairs();
            ListNode head = input.BuildList();
            int[] actual;

            //Act
            actual = solution.SwapPairs(head).ToArray();

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
