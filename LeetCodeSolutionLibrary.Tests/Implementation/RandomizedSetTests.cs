using LeetCodeLibrary.Implementation;
using Xunit;

namespace LeetCodeLibrary.Tests.Implementation
{
    public class RandomizedSetTests
    {
        [Fact]
        public void RandomizedSet_MethodsShouldReturnExpectedValue()
        {
            //Arrange
            RandomizedSet rs = new RandomizedSet();

            //Act & Assert
            Assert.True(rs.Insert(1) == true); // Inserts 1 to the set. Returns true as 1 was inserted successfully.
            Assert.True(rs.Remove(2) == false); // Returns false as 2 does not exist in the set.
            Assert.True(rs.Insert(2) == true); // Inserts 2 to the set, returns true. Set now contains [1,2].

            int random = rs.GetRandom();
            Assert.True(random == 1 || random == 2); // getRandom() should return either 1 or 2 randomly.

            Assert.True(rs.Remove(1) == true); // Removes 1 from the set, returns true. Set now contains [2].
            Assert.True(rs.Insert(2) == false); // 2 was already in the set, so return false.
            Assert.True(rs.GetRandom() == 2); // Since 2 is the only number in the set, getRandom() will always return 2.
        }
    }
}
