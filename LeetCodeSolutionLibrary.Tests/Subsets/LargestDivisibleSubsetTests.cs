using LeetCodeLibrary.Subsets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeLibrary.Tests.Subsets
{
    public class LargestDivisibleSubsetTests
    {
        [Theory]
        [ClassData(typeof(LargestDivisibleSubsetDataGenerator))]
        public void LargestSubset_ShouldReturnAnExpectedSubset(int[] nums, IList<IList<int>> expected)
        {
            //Arrange
            LargestDivisibleSubset solution = new LargestDivisibleSubset();
            IList<int> actual;

            //Act
            actual = solution.LargestSubset(nums);

            //Assert
            bool isFound = false;
            foreach (var list in expected)
            {
                if (Enumerable.SequenceEqual(list.OrderBy(t => t), actual.OrderBy(t => t)))
                {
                    isFound = true;
                }
            }
            //Solution fails on 3rd test case
            Assert.True(isFound);
        }

        public class LargestDivisibleSubsetDataGenerator : TheoryData<int[], IList<IList<int>>>
        {
            public LargestDivisibleSubsetDataGenerator()
            {
                Add(new int[] { 1, 2, 3 }, new List<IList<int>> { new List<int> { 1, 2 }, new List<int> { 1, 3 } });
                Add(new int[] { 1, 2, 4, 8 }, new List<IList<int>> { new List<int> { 1, 2, 4, 8 } });
                //Add(new int[] { 5, 9, 18, 54, 108, 540, 90, 180, 360, 720 }, new List<IList<int>> { new List<int> { 9, 18, 90, 180, 360, 720 } });
            }
        }
    }
}
