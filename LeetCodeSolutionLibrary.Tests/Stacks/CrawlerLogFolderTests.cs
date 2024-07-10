using System;
using LeetCodeSolutionLibrary.Stacks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Stacks
{
	public class CrawlerLogFolderTests
	{
		[Theory]
		[InlineData(2, new string[] { "d1/", "d2/", "../", "d21/", "./" })]
        [InlineData(3, new string[] { "d1/", "d2/", "./", "d3/", "../", "d31/" })]
        [InlineData(0, new string[] { "d1/", "../", "../", "../" })]
        public void MinOperations_ShouldReturnExpectedValue(int expected, string[] logs)
		{
			//Arrange
			CrawlerLogFolder solution = new CrawlerLogFolder();
			int actual;
			
			//Act
			 actual = solution.MinOperations(logs);
			
			//Assert
			Assert.Equal(expected, actual);
		}
	}
}