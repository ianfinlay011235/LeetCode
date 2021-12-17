using LeetCodeLibrary.DataStructures.Tree;
using LeetCodeSolutionLibrary.BinaryTrees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.BinaryTrees
{
    public class MaximumDepthOfBinaryTreeTests
    {
        [Theory]
        [ClassData(typeof(MaximumDepthOfBinaryTreeDataGenerator))]
        public void MaxDepth_ShouldReturnExpectedValue(int?[] arr, int expected)
        {
            //Arrange
            MaximumDepthOfBinaryTree solution = new MaximumDepthOfBinaryTree();
            TreeNode root = arr.BuildTree();
            int actual;

            //Act
            actual = solution.MaxDepth(root);

            //Assert
            Assert.Equal(expected, actual);
        }

        public class MaximumDepthOfBinaryTreeDataGenerator : TheoryData<int?[], int>
        {
            public MaximumDepthOfBinaryTreeDataGenerator()
            {
                Add(new int?[] { 3, 9, 20, null, null, 15, 7 }, 3);
                Add(new int?[] { 1, null, 2 }, 2);
                Add(Array.Empty<int?>(), 0);
                Add(new int?[] { 0 }, 1);
            }
        }
    }
}
