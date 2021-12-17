using LeetCodeLibrary.DataStructures.LinkedList;
using LeetCodeSolutionLibrary.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Sorting
{
    public class InsertionSortListTests
    {
        [Theory]
        [InlineData(new int[] { 4, 2, 1, 3 }, new int[] { 1, 2, 3, 4 })]
        [InlineData(new int[] { -1, 5, 3, 4, 0 }, new int[] { -1, 0, 3, 4, 5 })]
        public void InsertionSort_ShouldReturnHeadOfSortedList(int[] arr, int[] expected)
        {
            //Arrange
            InsertionSortList solution = new InsertionSortList();
            ListNode head = arr.BuildList();
            ListNode actual;

            //Act
            actual = solution.InsertionSort(head);

            //Assert
            Assert.Equal(expected, actual.ToArray());
        }
    }
}
