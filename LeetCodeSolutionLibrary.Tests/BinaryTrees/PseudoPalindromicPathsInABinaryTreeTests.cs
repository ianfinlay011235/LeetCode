using System;
using LeetCodeLibrary.DataStructures.Tree;
using LeetCodeSolutionLibrary.BinaryTrees;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.BinaryTrees
{
	public class PseudoPalindromicPathsInABinaryTreeTests
	{
		[Theory]
		[ClassData(typeof(PseudoPalindromicPathsInABinaryDataGenerator))]
		public void PseudoPalindromicPaths_ShouldReturnExpectedValue(int expected, int?[] tree)
		{
			//Arrange
			PseudoPalindromicPathsInABinaryTree solution = new PseudoPalindromicPathsInABinaryTree();
			TreeNode root = tree.BuildTree();
			int actual;
			
			//Act
			 actual = solution.PseudoPalindromicPaths(root);
			
			//Assert
			Assert.Equal(expected, actual);
		}
	}

    public class PseudoPalindromicPathsInABinaryDataGenerator : TheoryData<int, int?[]>
    {
        public PseudoPalindromicPathsInABinaryDataGenerator()
        {
            Add(2, new int?[] { 2, 3, 1, 3, 1, null, 1 });
			Add(1, new int?[] { 2, 1, 1, 1, 3, null, null, null, null, null, 1 });
			Add(1, new int?[] { 9 });
		}
    }
}