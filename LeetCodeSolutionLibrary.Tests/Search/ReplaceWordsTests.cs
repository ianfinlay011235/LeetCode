using System;
using System.Collections.Generic;
using LeetCodeSolutionLibrary.Search;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Search
{
	public class ReplaceWordsTests
	{
		[Theory]
		[InlineData("the cat was rat by the bat", new string[] { "cat", "bat", "rat" }, "the cattle was rattled by the battery")]
		[InlineData("a a b c", new string[] { "a", "b", "c" }, "aadsfasf absbs bbab cadsfafs")]
		[InlineData("it is ab that this solution is ac", new string[] { "ac", "ab" }, "it is abnormal that this solution is accepted")]
		public void Replace_ShouldReturnExpectedValue(string expected, IList<string> dictionary, string sentence)
		{
			//Arrange
			ReplaceWords solution = new ReplaceWords();
			string actual;
			
			//Act
			 actual = solution.Replace(dictionary, sentence);
			
			//Assert
			Assert.Equal(expected, actual);
		}
	}
}