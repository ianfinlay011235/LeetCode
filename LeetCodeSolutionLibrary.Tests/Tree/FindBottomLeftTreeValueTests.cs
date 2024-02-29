using System;
using LeetCodeLibrary.DataStructures.Tree;
using LeetCodeSolutionLibrary.Tree;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Tree
{
	public class FindBottomLeftTreeValueTests
	{
		[Theory]
		[ClassData(typeof(FindBottomLeftTreeValueDataGenerator))]
		public void FindBottomLeftValue_ShouldReturnExpectedValue(int expected, TreeNode root)
		{
			//Arrange
			FindBottomLeftTreeValue solution = new FindBottomLeftTreeValue();
			int actual;
			
			//Act
			 actual = solution.FindBottomLeftValue(root);
			
			//Assert
			Assert.Equal(expected, actual);
		}
	}

    public class FindBottomLeftTreeValueDataGenerator : TheoryData<int, TreeNode>
    {
        public FindBottomLeftTreeValueDataGenerator()
        {
            Add(1, new int?[] { 2, 1, 3 }.BuildTree());
			Add(7, new int?[] { 1, 2, 3, 4, null, 5, 6, null, null, 7 }.BuildTree());
		}
    }
}