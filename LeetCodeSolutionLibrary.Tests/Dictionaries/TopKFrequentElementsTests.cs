using LeetCodeSolutionLibrary.Dictionaries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Dictionaries
{
    public class TopKFrequentElementsTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2 }, new int[] { 1, 1, 1, 2, 2, 3 }, 2)]
        [InlineData(new int[] { 1 }, new int[] { 1 }, 1)]
        [InlineData(new int[] { -1 }, new int[] { -1, -1 }, 1)]
        [InlineData(new int[] { -1, 2 }, new int[] { 4, 1, -1, 2, -1, 2, 3 }, 2)]
        public void TopKFrequent_ShouldReturnExpectedSet(int[] expected, int[] nums, int k)
        {
            //Arrange
            TopKFrequentElements obj = new TopKFrequentElements();
            int[] actaul;

            //Act
            actaul = obj.TopKFrequent(nums, k);
            Array.Sort(actaul);
            Array.Sort(expected);

            //Assert
            Assert.Equal(expected, actaul);
        }
    }
}
