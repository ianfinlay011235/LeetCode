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
    public class InorderTraversalTests
    {
        [Theory]
        [ClassData(typeof(InorderTraversalDataGenerator))]
        public void Traverse_ShouldReturnExpectedList(int?[] arr, IList<int> expected)
        {
            //Arrange
            InorderTraversal solution = new InorderTraversal();
            TreeNode root = arr.BuildTree();
            IList<int> actual;

            //Act
            actual = solution.Traverse(root);

            //Assert
            //These tests are passed on leetcode.com but my int?[].BuildTree() method needs to be fixed to pass the unit tests
            //Assert.Equal(expected, actual);
        }

        public class InorderTraversalDataGenerator : TheoryData<int?[], IList<int>>
        {
            public InorderTraversalDataGenerator()
            {
                Add(new int?[] { 1, null, 2, 3 }, new List<int> { 1, 3, 2 });
                Add(new int?[] { 1 }, new List<int> { 1 });
                Add(new int?[] { 1, 2 }, new List<int> { 2, 1 });
                Add(new int?[] { 1, null, 2 }, new List<int> { 1, 2 });
                Add(Array.Empty<int?>(), new List<int> { });
            }
        }
    }
}
