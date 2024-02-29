using System;
using LeetCodeSolutionLibrary.Strings;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Strings
{
	public class FirstUniqueCharacterInStringTests
	{
		[Theory]
		[InlineData(0, "leetcode")]
		[InlineData(2, "loveleetcode")]
		[InlineData(-1, "aabb")]
		public void FirstUniqChar_ShouldReturnExpectedValue(int expected, string s)
		{
			//Arrange
			FirstUniqueCharacterInString solution = new FirstUniqueCharacterInString();
			int actual;
			
			//Act
			 actual = solution.FirstUniqChar(s);
			
			//Assert
			Assert.Equal(expected, actual);
		}
	}
}