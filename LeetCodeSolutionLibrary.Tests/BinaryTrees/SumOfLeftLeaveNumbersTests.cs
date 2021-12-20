using LeetCodeLibrary.BinaryTrees;
using LeetCodeLibrary.DataStructures.Tree;
using Xunit;

namespace LeetCodeLibrary.Tests.BinaryTrees
{
    public class SumOfLeftLeaveNumbersTests
    {
        [Theory]
        [ClassData(typeof(SumOfLeftLeaveNumbersDataGenerator))]
        public void SumOfLeftLeaves_ShouldReturnExpectedValue(int?[] arr, int expected)
        {
            //Arrange
            SumOfLeftLeaveNumbers solution = new SumOfLeftLeaveNumbers();
            TreeNode root = arr.BuildTree();
            int actual;

            //Act
            actual = solution.SumOfLeftLeaves(root);

            //Assert
            Assert.Equal(expected, actual);
        }

        public class SumOfLeftLeaveNumbersDataGenerator : TheoryData<int?[], int>
        {
            public SumOfLeftLeaveNumbersDataGenerator()
            {
                Add(new int?[] { 3, 9, 20, null, null, 15, 7 }, 24);
                Add(new int?[] { 1 }, 0);
            }
        }
    }
}
