using LeetCodeLibrary.Arrays;
using Xunit;

namespace LeetCodeLibrary.Tests.Arrays
{
    public class NextGreaterElementTests
    {
        [Theory]
        [InlineData(new int[] { 4, 1, 2 }, new int[] { 1, 3, 4, 2 }, new int[] { -1, 3, -1 })]
        [InlineData(new int[] { 2, 4 }, new int[] { 1, 2, 3, 4 }, new int[] { 3, -1 })]
        public void NextGreaterElement_ShouldReturnExpectedArray(int[] nums1, int[]nums2, int[]expected)
        {
            //ARRANGE
            NextGreaterElement1 nge = new NextGreaterElement1();

            //ACT
            int[] actual = nge.NextGreaterElement(nums1, nums2);

            //ASSERT
            Assert.Equal(expected, actual);
        }
    }
}
