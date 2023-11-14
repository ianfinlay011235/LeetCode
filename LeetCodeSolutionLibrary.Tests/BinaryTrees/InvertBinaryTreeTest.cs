using LeetCodeLibrary.BinaryTrees;
using LeetCodeLibrary.DataStructures.Tree;
using Xunit;

namespace LeetCodeLibrary.Tests.BinaryTrees
{
    public class InvertBinaryTreeTest
    {
        [Theory]
        [ClassData(typeof(InvertBinaryTreeDataGenerator))]
        public void InvertTree_ShouldReturnInvertedTree(int?[] arr, int?[] expected)
        {
            //Arrange
            InvertBinaryTree ibt = new InvertBinaryTree();
            TreeNode root = arr.BuildTree();

            //Act
            TreeNode actual = ibt.InvertTree(root);

            //Assert
            Assert.Equal(expected, actual.ToLevelOrderArray());
        }

        public class InvertBinaryTreeDataGenerator : TheoryData<int?[], int?[]>
        {
            public InvertBinaryTreeDataGenerator()
            {
                Add(new int?[] { 4, 2, 7, 1, 3, 6, 9 }, new int?[] { 4, 7, 2, 9, 6, 3, 1 });
                Add(new int?[] { 2, 1, 3 }, new int?[] { 2, 3, 1 });
                Add(new int?[] { }, new int?[] { });
            }
        }
    }
}
