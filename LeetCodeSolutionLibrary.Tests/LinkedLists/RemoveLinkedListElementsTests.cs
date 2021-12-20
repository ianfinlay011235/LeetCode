using LeetCodeLibrary.DataStructures.LinkedList;
using LeetCodeLibrary.LinkedLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeLibrary.Tests.LinkedLists
{
    public class RemoveLinkedListElementsTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 6, 3, 4, 5, 6 }, new int[] { 1, 2, 3, 4, 5 }, 6)]
        [InlineData(new int[] { }, new int[] { }, 1)]
        [InlineData(new int[] { 7, 7, 7, 7 }, new int[] { }, 7)]
        public void RemoveElements_ShouldReturnExpectedList(int[] arr, int[] expArr, int val)
        {
            //Arrange
            RemoveLinkedListElements solution = new RemoveLinkedListElements();
            ListNode head = arr.BuildList();
            ListNode expected = expArr.BuildList();
            ListNode actual;

            //Act
            actual = solution.RemoveElements(head, val);

            //Assert
            Assert.Equal(expected.ToArray(), actual.ToArray());
        }
    }
}
