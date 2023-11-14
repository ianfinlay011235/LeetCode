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
    public class MergeTwoSortedListsTests
    {
        [Theory]
        [InlineData(new int[] { 1, 1, 2, 3, 4, 4 }, new int[] { 1, 2, 4 }, new int[] { 1, 3, 4 })]
        [InlineData(new int[] { }, new int[] { }, new int[] { })]
        [InlineData(new int[] { 0 }, new int[] { }, new int[] { 0 })]
        public void MergeTwoLists_ShouldReturnExpectedList(int[] expected, int[] array1, int[] array2)
        {
            //Arrange
            MergeTwoSortedLists solution = new MergeTwoSortedLists();
            ListNode list1 = array1.BuildList();
            ListNode list2 = array2.BuildList();
            ListNode actual;

            //Act
            actual = solution.MergeTwoLists(list1, list2);

            //Assert
            Assert.Equal(expected, actual.ToArray());
        }
    }
}
