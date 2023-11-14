using LeetCodeSolutionLibrary.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Arrays
{
    public class FindTheDifferenceOfTwoArraysTests
    {
        [Theory]
        [ClassData(typeof(FindTheDifferenceOfTwoArraysTestsDataGenerator))]
        public void FindDifference_ShouldReturnExpectedValues(IList<IList<int>> expected, int[] nums1, int[] nums2)
        {
            //Arrange
            FindTheDifferenceOfTwoArrays solution = new FindTheDifferenceOfTwoArrays();
            IList<IList<int>> actual;

            //Act
            actual = solution.FindDifference(nums1, nums2);

            //Assert
            Assert.Equal(expected, actual);
        }
    }

    public class FindTheDifferenceOfTwoArraysTestsDataGenerator : TheoryData<List<IList<int>>, int[], int[]>
    {
        public FindTheDifferenceOfTwoArraysTestsDataGenerator()
        {
            Add(
                new List<IList<int>> 
                { 
                    new List<int> { 1, 3 }, 
                    new List<int> { 4, 6 } 
                }, 
                new int[] { 1, 2, 3 }, 
                new int[] { 2, 4, 6 });
            Add(
                new List<IList<int>> 
                { 
                    new List<int> { 3 }, 
                    new List<int> { } 
                }, 
                new int[] { 1, 2, 3, 3 }, 
                new int[] { 1, 1, 2, 2 });
        }
    }
}
