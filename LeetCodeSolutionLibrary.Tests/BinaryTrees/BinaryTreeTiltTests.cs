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
    public class BinaryTreeTiltTests
    {
        [Theory]
        [ClassData(typeof(BinaryTreeTiltDataGenerator))]
        public void FindTilt_ShouldReturnExpectedValue(int?[] arr, int expected)
        {
            //Arrange
            BinaryTreeTilt solution = new BinaryTreeTilt();
            TreeNode root = arr.BuildTree();
            int actual;

            //Act
            actual = solution.FindTilt(root);

            //Assert
            Assert.Equal(expected, actual);
        }

        public class BinaryTreeTiltDataGenerator : TheoryData<int?[], int>
        {
            public BinaryTreeTiltDataGenerator()
            {
                Add(new int?[] { 1, 2, 3 }, 1);
                Add(new int?[] { 4, 2, 9, 3, 5, null, 7 }, 15);
                Add(new int?[] { 21, 7, 14, 1, 1, 2, 2, 3, 3 }, 9);
            }
        }
    }
}
