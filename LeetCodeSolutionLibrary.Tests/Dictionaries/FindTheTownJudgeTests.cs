using System;
using LeetCodeSolutionLibrary.Dictionaries;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Dictionaries
{
	public class FindTheTownJudgeTests
	{
		[Theory]
		[ClassData(typeof(FindTheTownJudgeDataGenerator))]
		public void FindJudge_ShouldReturnExpectedValue(int expected, int n, int[][] trust)
		{
			//Arrange
			FindTheTownJudge solution = new FindTheTownJudge();
			int actual;
			
			//Act
			 actual = solution.FindJudge(n, trust);
			
			//Assert
			Assert.Equal(expected, actual);
		}
	}

    public class FindTheTownJudgeDataGenerator : TheoryData<int, int, int[][]>
    {
        public FindTheTownJudgeDataGenerator()
        {
            Add(2, 2, new int[][] { new int[] { 1, 2 } });
            Add(3, 3, new int[][] { new int[] { 1, 3 }, new int[] { 2, 3 } });
            Add(-1, 3, new int[][] { new int[] { 1, 3 }, new int[] { 2, 3 }, new int[] { 3, 1 } });
            Add(-1, 3, new int[][] { new int[] { 1, 2 }, new int[] { 2, 3 } });
		}
    }
}