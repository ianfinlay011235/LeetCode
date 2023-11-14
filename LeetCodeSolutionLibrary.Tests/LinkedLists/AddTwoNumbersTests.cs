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
    public class AddTwoNumbersTests
    {
        [Theory]
        [InlineData(new int[] { 7, 0, 8 }, new int[] { 2, 4, 3 }, new int[] { 5, 6, 4 })]
        [InlineData(new int[] { 0 }, new int[] { 0 }, new int[] { 0 })]
        [InlineData(new int[] { 8, 9, 9, 9, 0, 0, 0, 1 }, new int[] { 9, 9, 9, 9, 9, 9, 9 }, new int[] { 9, 9, 9, 9 })]
        public void AddTwoNumbers_ShouldReturnExpectedList(int[] expected, int[] a1, int[] a2)
        {
            //Arrange
            AddTwoNumbers solution = new AddTwoNumbers();
            ListNode l1 = a1.BuildList();
            ListNode l2 = a2.BuildList();
            int[] actual;

            //Act
            actual = solution.Add(l1, l2).ToArray();

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
