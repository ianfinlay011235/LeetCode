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
    public class OddEvenLinkedListTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 3, 5, 2, 4 })]
        [InlineData(new int[] { 2, 1, 3, 5, 6, 4, 7 }, new int[] { 2, 3, 6, 7, 1, 5, 4 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new int[] { 1, 3, 5, 7, 2, 4, 6, 8 })]
        public void OddEvenList_ShouldReturnExpectedListHead(int[] inputArr, int[] expectedArr)
        {
            //Arrange
            OddEvenLinkedList solution = new OddEvenLinkedList();
            ListNode head = inputArr.BuildList();
            ListNode expected = expectedArr.BuildList();
            ListNode actual;

            //Act
            actual = solution.OddEvenList(head);

            //Assert
            Assert.Equal(expected.ToArray(), actual.ToArray());
        }
    }
}
