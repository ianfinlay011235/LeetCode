using System;
using System.Collections.Generic;
using System.Linq;
using LeetCodeSolutionLibrary.Strings;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Strings
{
	public class GroupAnagramsTests
	{
		[Theory]
		[ClassData(typeof(GroupAnagramsDataGenerator))]
		public void GroupAnagrams_ShouldReturnExpectedCollection(IList<IList<string>> expected, string[] strs)
		{
			//Arrange
			GroupAnagrams solution = new GroupAnagrams();
			IList<IList<string>> actual;
			
			//Act
			 actual = solution.GetGroupAnagrams(strs);
			
			//Assert
			Assert.Equal(expected.Count, actual.Count);
            foreach (var aList in actual)
            {
				bool isFound = false;
                foreach (var eList in expected)
                {
                    if (Enumerable.SequenceEqual(aList.OrderBy(e => e), eList.OrderBy(e => e)))
                    {
						isFound = true;
						break;
                    }
                }
				Assert.True(isFound);
            }
		}
	}

    public class GroupAnagramsDataGenerator : TheoryData<IList<IList<string>>, string[]>
    {
        public GroupAnagramsDataGenerator()
        {
			Add(
				new List<IList<string>> { 
					new List<string> { "bat" }, 
					new List<string> { "nat", "tan" }, 
					new List<string> { "ate", "eat", "tea" } },
				new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });
			Add(new List<IList<string>> { new List<string> { "" } }, new string[] { "" });
			Add(new List<IList<string>> { new List<string> { "a" } }, new string[] { "a" });
        }
    }
}