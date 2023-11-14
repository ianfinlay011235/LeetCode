using LeetCodeSolutionLibrary.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Arrays
{
    public class Dota2SenateTests
    {
        [Theory]
        [InlineData("Radiant", "RD")]
        [InlineData("Dire", "RDD")]
        public void PredictPartyVictory_ShouldReturnExpectedValue(string expected, string senate)
        {
            //Arrange
            Dota2Senate solution = new Dota2Senate();
            string actual;

            //Act
            actual = solution.PredictPartyVictory(senate);


            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
