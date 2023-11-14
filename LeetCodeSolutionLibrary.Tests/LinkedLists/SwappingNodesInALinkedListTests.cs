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
    public class SwappingNodesInALinkedListTests
    {
        [Theory]
        [InlineData(new int[] { 1, 4, 3, 2, 5 }, new int[] { 1, 2, 3, 4, 5 }, 2)]
        [InlineData(new int[] { 7, 9, 6, 6, 8, 7, 3, 0, 9, 5 }, new int[] { 7, 9, 6, 6, 7, 8, 3, 0, 9, 5 }, 5)]
        public void SwapNodes_ShouldReturnExpectedList(int[] expected, int[] input, int k)
        {
            //Arrange
            SwappingNodesInALinkedList solution = new SwappingNodesInALinkedList();
            ListNode head = input.BuildList();
            int[] actual;

            //Act
            actual = solution.SwapNodes(head, k).ToArray();

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
