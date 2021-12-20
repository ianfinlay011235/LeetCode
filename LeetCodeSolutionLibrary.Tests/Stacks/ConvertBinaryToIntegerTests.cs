using LeetCodeLibrary.DataStructures.LinkedList;
using LeetCodeLibrary.Stacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeLibrary.Tests.Stacks
{
    public class ConvertBinaryToIntegerTests
    {
        [Theory]
        [InlineData(new int[] { 1, 0, 1 }, 5)]
        [InlineData(new int[] { 0 }, 0)]
        [InlineData(new int[] { 1 }, 1)]
        [InlineData(new int[] { 1, 0, 0, 1, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0 }, 18880)]
        [InlineData(new int[] { 0, 0 }, 0)]
        public void GetDecimalValue_ShouldReturnExpectedValue(int[] arr, int expected)
        {
            //Arrange
            ConvertBinaryToInteger solution = new ConvertBinaryToInteger();
            ListNode head = arr.BuildList();
            int actual;

            //Act
            actual = solution.GetDecimalValue(head);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
