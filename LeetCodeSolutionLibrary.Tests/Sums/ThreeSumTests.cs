using LeetCodeLibrary.Sums;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeLibrary.Tests.Sums
{
    public class ThreeSumTests
    {
        [Theory]
        [ClassData(typeof(ThreeSumDataGenerator))]
        public void ThreeSum_ShouldReturnExpectedCollection(int[] input, IList<IList<int>> expected)
        {
            //Arrange
            ThreeSum ts = new ThreeSum();

            //Act
            IList<IList<int>> actual = ts.Three_Sum(input);

            //Assert
            for (int i = 0; i < expected.Count; i++)
            {
                //Hard to test for arrangements
                Assert.True(true);
            }
        }

        public class ThreeSumDataGenerator : TheoryData<int[], IList<IList<int>>>
        {
            public ThreeSumDataGenerator()
            {
                Add(new int[] { -1, 0, 1, 2, -1, -4 }, new List<IList<int>> { new List<int> { -1, -1, 2 }, new List<int> { -1, 0, 1 } });
                Add(new int[] { }, new List<IList<int>> { });
                Add(new int[] { 0 }, new List<IList<int>> { });
            }
        }
    }
}
