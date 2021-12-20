using LeetCodeLibrary.BinaryTrees;
using LeetCodeLibrary.DataStructures.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeLibrary.Tests.BinaryTrees
{
    public class RangeSumOfBstTests
    {
        [Theory]
        [ClassData(typeof(RangeSumOfBastDataGenerator))]
        public void RangeSumBst_ShouldReturnExpectedValue(int?[] arr, int low, int high, int expected)
        {
            //Arrange
            RangeSumOfBst solution = new RangeSumOfBst();
            TreeNode root = arr.BuildTree();
            int actual;

            //Act
            actual = solution.RangeSumBst(root, low, high);

            //Assert
            Assert.Equal(expected, actual);
        }

        private class RangeSumOfBastDataGenerator : TheoryData<int?[], int, int, int>
        {
            public RangeSumOfBastDataGenerator()
            {
                Add(new int?[] { 10, 5, 15, 3, 7, null, 18 }, 7, 15, 32);
                Add(new int?[] { 10, 5, 15, 3, 7, 13, 18, 1, null, 6 }, 6, 10, 23);
            }
        }
    }
}
