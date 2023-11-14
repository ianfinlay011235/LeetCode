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
    public class MaximumWidthOfBinaryTreeTests
    {
        [Theory]
        [ClassData(typeof(MaximumWidthOfBinaryTreeDataGenerator))]
        public void WidthOfBinaryTree_ShouldReturnExpectedValue(int expected, int?[] array)
        {
            //Arrange
            MaximumWidthOfBinaryTree solution = new MaximumWidthOfBinaryTree();
            TreeNode root = array.BuildTree();
            int actual;

            //Act
            actual = solution.WidthOfBinaryTree(root);

            //Assert
            Assert.Equal(expected, actual);
        }
    }

    public class MaximumWidthOfBinaryTreeDataGenerator : TheoryData<int, int?[]>
    {
        public MaximumWidthOfBinaryTreeDataGenerator()
        {
            Add(4, new int?[] { 1, 3, 2, 5, 3, null, 9 });
            Add(7, new int?[] { 1, 3, 2, 5, null, null, 9, 6, null, 7 });
            Add(2, new int?[] { 1, 3, 2, 5 });
        }
    }
}
