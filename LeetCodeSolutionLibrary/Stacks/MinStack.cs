using System.Collections;

namespace LeetCodeLibrary.Stacks
{
    //https://leetcode.com/problems/min-stack/
    public class MinStack
    {
        private Stack _stack;
        private Stack _min;

        public MinStack()
        {
            _stack = new Stack();
            _min = new Stack();
        }

        public void Push(int val)
        {
            _stack.Push(val);
            if (_min.Count < 1 || (int)_min.Peek() >= val)
            {
                _min.Push(val);
            }
        }

        public void Pop()
        {
            if ((int)_stack.Pop() == (int)_min.Peek())
            {
                _min.Pop();
            }
        }

        public int Top() => (int)_stack.Peek();

        public int GetMin() => (int)_min.Peek();
    }
}
