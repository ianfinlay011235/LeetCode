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
    public class LongestZigZagPathTests
    {
        [Theory]
        [ClassData(typeof(LongestZigZagPathDataGenerator))]
        public void LongestZigZag_ShouldReturnExpectedValue(int expected, int?[] input)
        {
            //Arrange
            LongestZigZagPath solution = new LongestZigZagPath();
            TreeNode root = input.BuildTree();
            int actual;

            //Act
            actual = solution.LongestZigZag(root);

            //Assert
            Assert.Equal(expected, actual);
        }
    }

    public class LongestZigZagPathDataGenerator : TheoryData<int, int?[]>
    {
        public LongestZigZagPathDataGenerator()
        {
            Add(3, new int?[] { 1, null, 1, 1, 1, null, null, 1, 1, null, 1, null, null, null, 1, null, 1 });
            Add(4, new int?[] { 1, 1, 1, null, 1, null, null, 1, 1, null, 1 });
            Add(0, new int?[] { 1 });
            Add(5, new int?[] { 6, 9, 7, 3, null, 2, 8, 5, 8, 9, 7, 3, 9, 9, 4, 2, 10, null, 5, 4, 3, 10,
                10, 9, 4, 1, 2, null, null, 6, 5, null, null, null, null, 9, null, 9, 6, 5, null, 5, null,
                null, 7, 7, 4, null, 1, null, null, 3, 7, null, 9, null, null, null, null, null, null, null,
                null, 9, 9, null, null, null, 7, null, null, null, null, null, null, null, null, null, 6, 8,
                7, null, null, null, 3, 10, null, null, null, null, null, 1, null, 1, 2 });
        }
    }
}
