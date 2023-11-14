using LeetCodeSolutionLibrary.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Strings
{
    public class RemoveStarsFromAStringTests
    {
        [Theory]
        [InlineData("lecoe", "leet**cod*e")]
        [InlineData("", "erase*****")]
        public void RemoveStars_ShouldReturnExpectedValue(string expected, string s)
        {
            //Arrange
            RemoveStarsFromAString solution = new RemoveStarsFromAString();
            string actual;

            //Act
            actual = solution.RemoveStars(s);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
