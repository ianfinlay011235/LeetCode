using LeetCodeSolutionLibrary.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Design
{
    public class MyHashSetTests
    {
        [Theory]
        [ClassData(typeof(MyHashSetDataGenerator))]
        public void MyHashSet_ShouldReturnExpectedOuputSequence(bool?[] expected, string[] functions, int?[] inputs)
        {
            //Arrange
            MyHashSet obj = null;
            bool?[] actual = new bool?[expected.Length];

            //Act
            for (int i = 0; i < functions.Length; i++)
            {
                switch (functions[i])
                {
                    case "MyHashSet":
                        obj = new MyHashSet();
                        actual[i] = null;
                        break;
                    case "add":
                        obj.Add((int)inputs[i]);
                        actual[i] = null;
                        break;
                    case "remove":
                        obj.Remove((int)inputs[i]);
                        actual[i] = null;
                        break;
                    case "contains":
                        actual[i] = obj.Contains((int)inputs[i]);
                        break;
                }
            }

            //Assert
            Assert.Equal(expected, actual);
        }
    }

    public class MyHashSetDataGenerator : TheoryData<bool?[], string[], int?[]>
    {
        public MyHashSetDataGenerator()
        {
            Add(new bool?[] { null, null, null, true, false, null, true, null, false },
                new string[] { "MyHashSet", "add", "add", "contains", "contains", "add", "contains", "remove", "contains" },
                new int?[] { null, 1, 2, 1, 3, 2, 2, 2, 2 });
        }
    }
}
