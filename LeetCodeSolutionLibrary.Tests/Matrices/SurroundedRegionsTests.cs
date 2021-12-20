using LeetCodeLibrary.Matrices;
using Xunit;

namespace LeetCodeLibrary.Tests.Matrices
{
    public class SurroundedRegionsTests
    {
        [Theory]
        [ClassData(typeof(SurroundedRegionsDataGenerator))]
        public void Solve_ShouldManipulateBoardIntoExpectedConfiguration(char[][] actual, char[][] expected) 
        {
            //Arrange
            SurroundedRegions sr = new SurroundedRegions();

            //Act
            sr.Solve(actual);

            //Assert
            Assert.Equal(expected, actual);
        }

        public class SurroundedRegionsDataGenerator : TheoryData<char[][], char[][]>
        {
            public SurroundedRegionsDataGenerator()
            {
                //Example 1:
                Add(new char[][] 
                {
                    new char [] { 'X', 'X', 'X', 'X' },
                    new char [] { 'X', 'O', 'O', 'X' },
                    new char [] { 'X', 'X', 'O', 'X' },
                    new char [] { 'X', 'O', 'X', 'X' }
                }, 
                new char[][]
                {
                    new char [] { 'X', 'X', 'X', 'X' },
                    new char [] { 'X', 'X', 'X', 'X' },
                    new char [] { 'X', 'X', 'X', 'X' },
                    new char [] { 'X', 'O', 'X', 'X' }
                });

                //Example 2:
                Add(new char[][] 
                {
                    new char[] { 'X' }
                }, 
                new char[][]
                {
                    new char[] { 'X' }
                });
            }
        }
    }
}
