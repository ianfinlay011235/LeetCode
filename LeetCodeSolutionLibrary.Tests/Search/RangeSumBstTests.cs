using LeetCodeLibrary.DataStructures.Tree;
using LeetCodeSolutionLibrary.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Search
{
    public class RangeSumBstTests
    {
        [Theory]
        [ClassData(typeof(RangeSumBstDataGenerator))]
        public void RangeSum_ShouldReturnExpectedValues(int expected, int?[] arr, int low, int high)
        {
            //Arrange
            RangeSumBst solution = new RangeSumBst();
            TreeNode root = arr.BuildTree();
            int actual;

            //Act
            actual = solution.RangeSum(root, low, high);

            //Assert
            Assert.Equal(expected, actual);
        }

        public class RangeSumBstDataGenerator : TheoryData<int, int?[], int, int>
        {
            public RangeSumBstDataGenerator()
            {
                Add(32, new int?[] { 10, 5, 15, 3, 7, null, 18 }, 7, 15);
                Add(23, new int?[] { 10, 5, 15, 3, 7, 13, 18, 1, null, 6 }, 6, 10);
            }
        }
    }
}
