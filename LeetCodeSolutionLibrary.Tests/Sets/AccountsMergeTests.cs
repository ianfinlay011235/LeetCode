using LeetCodeLibrary.Sets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeLibrary.Tests.Sets
{
    public class AccountsMergeTests
    {
        [Theory]
        [ClassData(typeof(AccountsMergeDataGenerator))]
        public void MergeAccounts_ShouldReturnExpectedValues(IList<IList<string>> accounts, IList<IList<string>> expected)
        {
            //Arrange
            AccountsMerge solution = new AccountsMerge();
            IList<IList<string>> actual;

            //Act
            actual = solution.MergeAccounts(accounts);

            //Assert
            Assert.Equal(expected.Count, actual.Count);
            foreach (var actualAccount in actual)
            {
                bool isFound = false;
                foreach (var expectedAccount in expected)
                {
                    if (Enumerable.SequenceEqual(actualAccount.OrderBy(t => t), expectedAccount.OrderBy(t => t)))
                    {
                        isFound = true;
                        break;
                    }
                }
                Assert.True(isFound);
            }
        }

        private class AccountsMergeDataGenerator : TheoryData<IList<IList<string>>, IList<IList<string>>>
        {
            public AccountsMergeDataGenerator()
            {
                Add(
                    new List<IList<string>> 
                    {
                        new List<string> { "John", "johnsmith@mail.com", "john_newyork@mail.com" }, 
                        new List<string> { "John", "johnsmith@mail.com", "john00@mail.com" },
                        new List<string> { "Mary","mary@mail.com" },
                        new List<string> { "John","johnnybravo@mail.com" }, 
                    },
                    new List<IList<string>>
                    {
                        new List<string> { "John","john00@mail.com","john_newyork@mail.com","johnsmith@mail.com" },
                        new List<string> { "Mary","mary@mail.com" },
                        new List<string> { "John", "johnnybravo@mail.com" }
                    });
                Add(
                    new List<IList<string>>
                    {
                        new List<string> { "Gabe","Gabe0@m.co","Gabe3@m.co","Gabe1@m.co" },
                        new List<string> { "Kevin","Kevin3@m.co","Kevin5@m.co","Kevin0@m.co" },
                        new List<string> { "Ethan","Ethan5@m.co","Ethan4@m.co","Ethan0@m.co" },
                        new List<string> { "Hanzo","Hanzo3@m.co","Hanzo1@m.co","Hanzo0@m.co" },
                        new List<string> { "Fern", "Fern5@m.co", "Fern1@m.co", "Fern0@m.co" }
                    },
                    new List<IList<string>>
                    {
                        new List<string> { "Ethan","Ethan0@m.co","Ethan4@m.co","Ethan5@m.co" },
                        new List<string> { "Gabe","Gabe0@m.co","Gabe1@m.co","Gabe3@m.co" },
                        new List<string> { "Hanzo","Hanzo0@m.co","Hanzo1@m.co","Hanzo3@m.co" },
                        new List<string> { "Kevin","Kevin0@m.co","Kevin3@m.co","Kevin5@m.co" },
                        new List<string> { "Fern","Fern0@m.co","Fern1@m.co","Fern5@m.co" }
                    });
            }
        }
    }
}
