using System;
using LeetCodeLibrary.DataStructures.Tree;
using LeetCodeSolutionLibrary.Tree;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Tree
{
	public class SameTreeTests
	{
		[Theory]
		[ClassData(typeof(SameTreeDataGenerator))]
		public void IsSameTree_ShouldReturnExpectedValue(bool expected, int?[] t1, int?[] t2)
		{
			//Arrange
			SameTree solution = new SameTree();
			TreeNode p = t1.BuildTree();
			TreeNode q = t2.BuildTree();

			bool actual;
			
			//Act
			 actual = solution.IsSameTree(p, q);
			
			//Assert
			Assert.Equal(expected, actual);
		}
	}

	public class SameTreeDataGenerator : TheoryData<bool, int?[], int?[]>
	{
		public SameTreeDataGenerator()
		{
			Add(true, new int?[] { 1, 2, 3 }, new int?[] { 1, 2, 3 });
			Add(false, new int?[] { 1, 2 }, new int?[] { 1, null, 2 });
			Add(false, new int?[] { 1, 2, 1 }, new int?[] { 1, 1, 2 });
		}
	}
}