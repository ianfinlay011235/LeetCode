using LeetCodeLibrary.BinaryTrees;
using LeetCodeLibrary.DataStructures.Tree;
using Xunit;

namespace LeetCodeLibrary.Tests.BinaryTrees
{
    public class SumRootToLeafNumbersTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, 25)]
        [InlineData(new int[] { 4, 9, 0, 5, 1 }, 1026)]
        public void SumNumbers_ShouldReturnExpectedSum(int[] arr, int expected)
        {
            //Arrange
            int actual;
            TreeNode root = arr.BuildTree();
            SumRootToLeafNumbers solution = new SumRootToLeafNumbers();

            //Act
            actual = solution.SumNumbers(root);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
