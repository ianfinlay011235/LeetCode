using LeetCodeSolutionLibrary.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Design
{
    public class UndergroundSystemTests
    {
        [Theory]
        [ClassData(typeof(UndergroundSystemDataGenerator))]
        public void UndergroundSystem_ShouldReturnExpectedOuputSequence(double?[] expected, string[] functions, object[][] inputs)
        {
            //Arrange
            UndergroundSystem obj = null;
            double?[] actual = new double?[expected.Length];

            //Act
            for (int i = 0; i < functions.Length; i++)
            {
                switch (functions[i])
                {
                    case "UndergroundSystem":
                        obj = new UndergroundSystem();
                        actual[i] = null;
                        break;
                    case "checkIn":
                        obj.CheckIn((int)inputs[i][0], (string)inputs[i][1], (int)inputs[i][2]);
                        actual[i] = null;
                        break;
                    case "checkOut":
                        obj.CheckOut((int)inputs[i][0], (string)inputs[i][1], (int)inputs[i][2]);
                        actual[i] = null;
                        break;
                    case "getAverageTime":
                        actual[i] = obj.GetAverageTime((string)inputs[i][0], (string)inputs[i][1]);
                        break;
                }
            }

            //Assert
            for (int i = 0; i < expected.Length; i++)
            {
                if (expected[i] == null)
                {
                    Assert.Equal(expected[i], actual[i]);
                }
                else
                {
                    Assert.True(expected[i] - 0.00001 <= actual[i] && actual[i] <= expected[i] + 0.00001);
                }
            }
        }
    }

    public class UndergroundSystemDataGenerator : TheoryData<double?[], string[], object[][]>
    {
        public UndergroundSystemDataGenerator()
        {
            Add(new double?[] { null, null, null, null, null, null, null, 14.00000, 11.00000, null, 11.00000, null, 12.00000 },
                new string[] { "UndergroundSystem", "checkIn", "checkIn", "checkIn", "checkOut", "checkOut", "checkOut",
                    "getAverageTime", "getAverageTime", "checkIn", "getAverageTime", "checkOut", "getAverageTime" },
                new object[][] {
                    null, new object[] { 45, "Leyton", 3 }, new object[] { 32, "Paradise", 8 },
                    new object[] { 27, "Leyton", 10 }, new object[] { 45, "Waterloo", 15 }, new object[] { 27, "Waterloo", 20 },
                    new object[] { 32, "Cambridge", 22}, new object[] { "Paradise", "Cambridge" }, new object[] { "Leyton", "Waterloo" },
                    new object[] { 10, "Leyton", 24 }, new object[] { "Leyton", "Waterloo" }, new object[] { 10, "Waterloo", 38 },
                    new object[] { "Leyton", "Waterloo" }
                });
            Add(new double?[] { null, null, null, 5.00000, null, null, 5.50000, null, null, 6.66667 },
                new string[] { "UndergroundSystem", "checkIn", "checkOut", "getAverageTime", "checkIn", "checkOut",
                    "getAverageTime", "checkIn", "checkOut", "getAverageTime" },
                new object[][] {
                    null, new object[] { 10, "Leyton", 3 }, new object[] { 10, "Paradise", 8 }, new object[] { "Leyton", "Paradise" },
                    new object[] { 5, "Leyton", 10 }, new object[] { 5, "Paradise", 16 }, new object[] { "Leyton", "Paradise" },
                    new object[] { 2, "Leyton", 21 }, new object[] { 2, "Paradise", 30 }, new object[] { "Leyton", "Paradise" } });
        }
    }
}
