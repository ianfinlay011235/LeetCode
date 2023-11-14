using LeetCodeSolutionLibrary.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Design
{
    public class ParkingSystemTests
    {
        [Theory]
        [ClassData(typeof(ParkingSystemDataGenerator))]
        public void ParkingSystem_ShouldReturnExpectedResultsSequence(bool?[] expected, string[] functions, int[] constructor, int[] addCar)
        {
            //Arrange
            ParkingSystem obj = null;
            bool?[] actual = new bool?[expected.Length];

            //Act
            for (int i = 0; i < functions.Length; i++)
            {
                switch (functions[i])
                {
                    case "ParkingSystem":
                        obj = new ParkingSystem(constructor[0], constructor[1], constructor[2]);
                        actual[i] = null;
                        break;
                    case "addCar":
                        if (obj != null)
                        {
                            actual[i] = obj.AddCar(addCar[i - 1]);
                        }
                        break;
                }
            }

            //Assert
            Assert.Equal(expected, actual);
        }
    }

    public class ParkingSystemDataGenerator : TheoryData<bool?[], string[], int[], int[]>
    {
        public ParkingSystemDataGenerator()
        {
            Add(new bool?[] { null, true, true, false, false }, 
                new string[] { "ParkingSystem", "addCar", "addCar", "addCar", "addCar" },
                new int[] { 1, 1, 0 },
                new int[] { 1, 2, 3, 1 });
        }
    }
}
