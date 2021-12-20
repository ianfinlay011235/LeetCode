using LeetCodeLibrary.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeLibrary.Tests.Search
{
    public class SearchInsertPositionTests
    {
        [Theory]
        [InlineData(new int[] { 1, 3, 5, 6 }, 5, 2)]
        [InlineData(new int[] { 1, 3, 5, 6 }, 2, 1)]
        [InlineData(new int[] { 1, 3, 5, 6 }, 7, 4)]
        [InlineData(new int[] { 1, 3, 5, 6 }, 0, 0)]
        [InlineData(new int[] { 1 }, 0, 0)]
        public void SearchInsert_ShouldReturnExpectedInt(int[] nums, int target, int expected)
        {
            //Arrange
            SearchInsertPosition solution = new SearchInsertPosition();
            int actual;

            //Act
            actual = solution.SearchInsert(nums, target);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
