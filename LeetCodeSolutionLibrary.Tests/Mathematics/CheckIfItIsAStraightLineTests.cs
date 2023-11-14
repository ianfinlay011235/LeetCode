using LeetCodeSolutionLibrary.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Mathematics
{
    public class CheckIfItIsAStraightLineTests
    {
        [Theory]
        [ClassData(typeof(CheckIfItIsAStraightLineDataGenerator))]
        public void CheckStraightLine_ShouldReturnExpectedValue(bool expected, int[][] coordinates)
        {
            //Arrange
            CheckIfItIsAStraightLine obj = new CheckIfItIsAStraightLine();
            bool actual;

            //Act
            actual = obj.CheckStraightLine(coordinates);

            //Assert
            Assert.Equal(expected, actual);
        }
    }

    public class CheckIfItIsAStraightLineDataGenerator : TheoryData<bool, int[][]>
    {
        public CheckIfItIsAStraightLineDataGenerator()
        {
            Add(true, 
                new int[][] 
                {
                    new int[] { 1, 2 }, 
                    new int[] { 2, 3 }, 
                    new int[] { 3, 4 }, 
                    new int[] { 4, 5 }, 
                    new int[] { 5, 6 }, 
                    new int[] { 6, 7 } 
                });

            Add(false, 
                new int[][]
                {
                    new int[] { 1,1 },
                    new int[] { 2,2 },
                    new int[] { 3, 4 },
                    new int[] { 4, 5 },
                    new int[] { 5, 6 },
                    new int[] { 7, 7 }
                });
        }
    }
}
