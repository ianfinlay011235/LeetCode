using System;
using System.Collections.Generic;
using LeetCodeSolutionLibrary.Dictionaries;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Dictionaries
{
	public class LetterCombinationsOfAPhoneNumberTests
	{
		[Theory]
		[ClassData(typeof(LetterCombinationsOfAPhoneNumberDataGenerator))]
		public void LetterCombinations_ShouldReturnExpectedCollection(IList<string> expected, string digits)
		{
			//Arrange
			LetterCombinationsOfAPhoneNumber solution = new LetterCombinationsOfAPhoneNumber();
			IList<string> actual;
			
			//Act
			 actual = solution.LetterCombinations(digits);
			
			//Assert
			Assert.Equal(expected, actual);
		}
	}

    public class LetterCombinationsOfAPhoneNumberDataGenerator : TheoryData<IList<string>, string>
    {
        public LetterCombinationsOfAPhoneNumberDataGenerator()
        {
            Add(new List<string> { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" }, "23");
			Add(new List<string> { }, "");
			Add(new List<string> { "a", "b", "c" }, "2");
		}
    }
}