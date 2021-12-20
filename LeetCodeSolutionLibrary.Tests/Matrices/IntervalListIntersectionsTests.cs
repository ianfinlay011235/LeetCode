using LeetCodeLibrary.Matrices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeLibrary.Tests.Matrices
{
    public class IntervalListIntersectionsTests
    {
        [Theory]
        [ClassData(typeof(IntervalListIntersectionsDataGenerator))]
        public void IntervalIntersection_ShouldReturnExpectedValue(int[][] firstList, int[][] secondList, int[][] expected)
        {
            //Arrange
            IntervalListIntersections solution = new IntervalListIntersections();
            int[][] actual;

            //Act
            actual = solution.IntervalIntersection(firstList, secondList);

            //Assert
            Assert.Equal(expected, actual);
        }

        public class IntervalListIntersectionsDataGenerator : TheoryData<int[][], int[][], int[][]>
        {
            public IntervalListIntersectionsDataGenerator()
            {
                Add(new int[][] { new int[] { 0, 2 }, new int[] { 5, 10 }, new int[] { 13, 23 }, new int[] { 24, 25 } },
                    new int[][] { new int[] { 1, 5 }, new int[] { 8, 12 }, new int[] { 15, 24 }, new int[] { 25, 26 } },
                    new int[][] { new int[] { 1, 2 }, new int[] { 5, 5 }, new int[] { 8, 10 }, new int[] { 15, 23 }, new int[] { 24, 24 }, new int[] { 25, 25 } });
                Add(new int[][] { new int[] { 1, 3 }, new int[] { 5, 9 } },
                    new int[][] { },
                    new int[][] { });
                Add(new int[][] { },
                    new int[][] { new int[] { 4, 8 }, new int[] { 10, 12 } },
                    new int[][] { });
                Add(new int[][] { new int[] { 1, 7 } },
                    new int[][] { new int[] { 3, 10 } },
                    new int[][] { new int[] { 3, 7 } });
                Add(new int[][] { new int[] { 4, 11 } },
                    new int[][] { new int[] { 1, 2 }, new int[] { 8, 11 }, new int[] { 12, 13 }, new int[] { 14, 15 }, new int[] { 17, 19 } },
                    new int[][] { new int[] { 8, 11 } });
                Add(new int[][] { new int[] { 5, 8 }, new int[] { 15, 18 } },
                    new int[][] { new int[] { 0, 3 }, new int[] { 7, 8 }, new int[] { 9, 12} },
                    new int[][] { new int[] { 7, 8 } });
            }
        }
    }
}
