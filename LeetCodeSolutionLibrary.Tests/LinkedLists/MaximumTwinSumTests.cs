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
    public class MaximumTwinSumTests
    {
        [Theory]
        [InlineData(6, new int[] { 5, 4, 2, 1 })]
        [InlineData(7, new int[] { 4, 2, 2, 3 })]
        [InlineData(100001, new int[] { 1, 100000 })]
        public void MaximumTwinSum_ShouldReturnExpectedValue(int expected, int[] input)
        {
            //Arrange
            MaximumTwinSum solution = new MaximumTwinSum();
            ListNode head = input.BuildList();
            int actual;

            //Act
            actual = solution.PairSum(head);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
