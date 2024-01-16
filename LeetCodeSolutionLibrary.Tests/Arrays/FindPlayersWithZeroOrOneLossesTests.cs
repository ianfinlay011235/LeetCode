using LeetCodeSolutionLibrary.Arrays;
using System;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Arrays
{
	public class FindPlayersWithZeroOrOneLossesTests
	{
		[Theory]
        [ClassData(typeof(FindPlayersWithZeroOrOneLossesDataGenerator))]
        public void FindWinners_ShouldReturnExpectedCollection(IList<IList<int>> expected, int[][] matches)
		{
			//Arrange
			FindPlayersWithZeroOrOneLosses solution = new FindPlayersWithZeroOrOneLosses();
			IList<IList<int>> actual;

			//Act
			actual = solution.FindWinners(matches);

			//Assert
			Assert.Equal(expected, actual);
		}

		public class FindPlayersWithZeroOrOneLossesDataGenerator : TheoryData<IList<IList<int>>, int[][]>
        {
            public FindPlayersWithZeroOrOneLossesDataGenerator()
            {
				Add(
					new List<IList<int>> { 
						new List<int> {1, 2, 10 },
						new List<int> {4, 5, 7, 8 } 
					}, 
					new int[][] {
						new int[] { 1, 3 }, 
						new int[] { 2, 3 }, 
						new int[] { 3, 6 }, 
						new int[] { 5, 6 }, 
						new int[] { 5, 7 }, 
						new int[] { 4, 5 }, 
						new int[] { 4, 8 }, 
						new int[] { 4, 9 }, 
						new int[] { 10, 4 },
						new int[] { 10, 9 } 
					});

				Add(
					new int[][]
                    {
						new int[] { 1, 2, 5, 6 },
						new int[] { }
					},
					new int[][]
                    {
						new int[] { 2, 3 }, 
						new int[] { 1, 3 }, 
						new int[] { 5, 4 }, 
						new int[] { 6, 4 } 
					});
            }
        }
	}
}