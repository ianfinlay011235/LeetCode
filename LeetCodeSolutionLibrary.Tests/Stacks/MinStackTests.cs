using LeetCodeLibrary.Stacks;
using Xunit;

namespace LeetCodeLibrary.Tests.Stack
{
    public class MinStackTests
    {
        [Fact]
        public void MinStack_MethodsShouldReturnExpectedValue()
        {
            //Arrange
            MinStack stack = new MinStack();

            //Act & Assert
            stack.Push(-2);
            stack.Push(0);
            stack.Push(-3);
            Assert.True(stack.GetMin() == -3);
            stack.Pop();
            Assert.True(stack.Top() == 0);
            Assert.True(stack.GetMin() == -2);
        }
    }
}
