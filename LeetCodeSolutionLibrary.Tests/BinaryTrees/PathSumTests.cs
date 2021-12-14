using LeetCodeLibrary.DataStructures.Tree;
using LeetCodeLibrary.BinaryTrees;
using Xunit;

namespace LeetCodeLibrary.Tests.BinaryTrees
{
    public class PathSumTests
    {
        [Theory]
        [ClassData(typeof(PathSum1DataGenerator))]
        public void HasPathSum_ShouldReturnExpectedValue(int?[] array, int targetSum, bool expected)
        {
            //ARRANGE
            TreeNode root = array.BuildTree();
            PathSum ps1 = new LeetCodeLibrary.BinaryTrees.PathSum();

            //ACT
            bool actual = ps1.HasPathSum(root, targetSum);

            //ASSERT
            Assert.Equal(expected, actual);
        }

        public class PathSum1DataGenerator : TheoryData<int?[], int, bool>
        {
            public PathSum1DataGenerator()
            {
                Add(new int?[] { 5, 4, 8, 11, null, 13, 4, 7, 2, null, null, null, 1 }, 22, true);
                Add(new int?[] { 1, 2, 3 }, 5, false);
                Add(new int?[] { 1, 2 }, 0, false);
                Add(new int?[] { 1, 2 }, 1, false);
            }
        }
    }
}
