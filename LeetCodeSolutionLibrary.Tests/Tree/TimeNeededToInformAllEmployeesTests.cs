using LeetCodeSolutionLibrary.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutionLibrary.Tests.Tree
{
    public class TimeNeededToInformAllEmployeesTests
    {
        [Theory]
        [InlineData(0, 1, 0, new int[] { -1 }, new int[] { 0 })]
        [InlineData(1, 6, 2, new int[] { 2, 2, -1, 2, 2, 2 }, new int[] { 0, 0, 1, 0, 0, 0 })]
        public void NumOfMinutes_ShouldReturnExpectedValue(int expected, int n, int headID, int[] manager, int[] informTime)
        {
            //Arrange
            TimeNeededToInformAllEmployees obj = new TimeNeededToInformAllEmployees();
            int actaul;

            //Act
            actaul = obj.NumOfMinutes(n, headID, manager, informTime);

            //Assert
            Assert.Equal(expected, actaul);
        }
    }
}
