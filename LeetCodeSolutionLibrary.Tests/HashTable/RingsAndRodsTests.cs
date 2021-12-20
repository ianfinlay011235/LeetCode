using LeetCodeSolutionLibrary.HashTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.HashTable
{
    public class RingsAndRodsTests
    {
        [Theory]
        [InlineData("B0B6G0R6R0R6G9", 1)]
        [InlineData("B0R0G0R9R0B0G0", 1)]
        [InlineData("G4", 0)]
        public void CountPoints_Tests(string rings, int expected)
        {
            //Arrange
            RingsAndRods solution = new RingsAndRods();
            int actual;

            //Act
            actual = solution.CountPoints(rings);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
