using LeetCodeSolutionLibrary.Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Queue
{
    public class SmallestNumberInInfiniteSetTests
    {
        [Theory]
        [ClassData(typeof(SmallestNumberInInfiniteSetTestsDataGenerator))]
        public void SmallestInfiniteSet_ShouldReturnExpectedOutput(string[] operations, List<int?> expected, int[] nums)
        {
            //Arrange
            SmallestNumberInInfiniteSet obj = null;
            int nInd = 0;
            List<int?> actual = new List<int?>();

            //Act
            foreach (var operation in operations)
            {
                switch (operation)
                {
                    case "SmallestInfiniteSet":
                        obj = new SmallestNumberInInfiniteSet();
                        actual.Add(null);
                        break;
                    case "popSmallest":
                        int smallest = obj.PopSmallest();
                        actual.Add(smallest);
                        break;
                    case "addBack":
                        obj.AddBack(nums[nInd++]);
                        actual.Add(null);
                        break;
                    default:
                        throw new ArgumentException($"Error: operation [{operation}] not found.");
                }
            }

            //Assert
            Assert.Equal(expected, actual);
        }
    }

    public class SmallestNumberInInfiniteSetTestsDataGenerator : TheoryData<string[], List<int?>, int[]>
    {
        public SmallestNumberInInfiniteSetTestsDataGenerator()
        {
            Add(
                new string[] { "SmallestInfiniteSet", "addBack", "popSmallest", "popSmallest", "popSmallest", 
                    "addBack", "popSmallest", "popSmallest", "popSmallest" },
                new List<int?> { null, null, 1, 2, 3, null, 1, 4, 5 },
                new int[] { 2, 1 }
                );
            Add(
                new string[] { "SmallestInfiniteSet", "addBack", "popSmallest", "popSmallest", "popSmallest",
                    "addBack", "popSmallest", "popSmallest", "popSmallest" },
                new List<int?> { null, null, 1, 2, 3, null, 1, 4, 5 },
                new int[] { 2, 1 }
                );
        }
    }
}
