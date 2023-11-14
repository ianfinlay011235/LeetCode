using LeetCodeSolutionLibrary.Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Queue
{
    public class KthLargestElementInAStreamTests
    {
        [Theory]
        [ClassData(typeof(KthLargestElementDataGenerator))]
        public void KthLargest_ShouldReturnExpectedSequenceOfOutputs(string[] actions, object[] inputs, int?[] expected)
        {
            //Arrange
            KthLargestElementInAStream obj = null;
            int?[] actual = new int?[actions.Length];

            //Act
            for (int i = 0; i < actions.Length; i++)
            {
                switch (actions[i])
                {
                    case "KthLargest":
                        ValueTuple<int, int[]> cv = (ValueTuple<int, int[]>)inputs[i];
                        obj = new KthLargestElementInAStream(cv.Item1, cv.Item2);
                        actual[i] = null;
                        break;
                    case "add":
                        actual[i] = obj.Add((int)inputs[i]);
                        break;
                }
            }

            //Assert
            Assert.Equal(expected, actual);
        }
    }

    public class KthLargestElementDataGenerator : TheoryData<string[], object[], int?[]>
    {
        public KthLargestElementDataGenerator()
        {
            Add(new string[] { "KthLargest", "add", "add", "add", "add", "add" },
                new object[] { (3, new int[] { 4, 5, 8, 2 }), 3, 5, 10, 9, 4 },
                new int?[] { null, 4, 5, 5, 8, 8 });
            Add(new string[] { "KthLargest", "add", "add", "add", "add", "add" },
                new object[] { (1, new int[] { }), -3, -2, -4, 0, 4 },
                new int?[] { null, -3, -2, -2, 0, 4 });
        }
    }
}
