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
    public class RemoveDuplicatesFromSortedListTests
    {
        [Theory]
        [InlineData(new int[] { 1, 1, 2 }, new int[] { 1, 2 })]
        [InlineData(new int[] { 1, 1, 2, 3, 3 }, new int[] { 1, 2, 3 })]
        public void DeleteDuplicates_ShouldReturnHeadOfExpectedList(int[] arr, int[] expected)
        {
            //Arrange
            RemoveDuplicatesFromSortedList solution = new RemoveDuplicatesFromSortedList();
            ListNode head = arr.BuildList();

            //Act
            ListNode actual = solution.DeleteDuplicates(head);

            //Assert
            Assert.Equal(expected, actual.ToArray());
        }
    }
}
