using LeetCodeLibrary.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeLibrary.Tests.Arrays
{
    public class FindAllNumbersDisappearedInAnArrayTests
    {
        [Theory]
        [InlineData(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 }, new int[] { 5, 6 })]
        [InlineData(new int[] { 1, 1 }, new int[] { 2 })]
        public void FindDisappearedNumbers_ShouldReturnExpectedArray(int[] nums, int[] expected)
        {
            //Arrange
            FindAllNumbersDisappearedInAnArray solution = new FindAllNumbersDisappearedInAnArray();
            IList<int> actual;

            //Act
            actual = solution.FindDisappearedNumbers(nums);

            //Assert
            Assert.True(Enumerable.SequenceEqual(expected.OrderBy(t => t), actual.OrderBy(t => t)));
        }
    }
}
