using LeetCodeSolutionLibrary.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Strings
{
    public class SimplifyPathTests
    {
        [Theory]
        [InlineData("/home", "/home/")]
        [InlineData("/", "/../")]
        [InlineData("/home/foo", "/home//foo/")]
        [InlineData("/c", "/a/./b/../../c/")]
        [InlineData("/ZWuLz/R", "/n/Qz/../../ZWuLz/./R/.//")]
        public void Simplify_ShouldReturnExpectedValue(string expected, string path) 
        {
            //Arrange
            SimplifyPath solution = new SimplifyPath();
            string actaul;

            //Act
            actaul = solution.Simplify(path);

            //Assert
            Assert.Equal(expected, actaul);
        }
    }
}
