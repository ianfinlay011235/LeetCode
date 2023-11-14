using LeetCodeSolutionLibrary.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Arrays
{
    public class ValidateStackSequencesTests
    {
        [Theory]
        [InlineData(true, new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 5, 3, 2, 1 })]
        [InlineData(false, new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 3, 5, 1, 2 })]
        public void ValidateSequences_ShouldReturnExpectedValue(bool expected, int[] pushed, int[] popped)
        {
            //Arrange
            ValidateStackSequences solution = new ValidateStackSequences();
            bool actual;

            //Act
            actual = solution.ValidateSequences(pushed, popped);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
