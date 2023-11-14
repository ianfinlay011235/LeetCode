using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.Arrays
{
    //https://leetcode.com/problems/validate-stack-sequences/

    public class ValidateStackSequences
    {
        /*
         * Time Complexity: O(N)
         *  -N is the length of pushed/popped
         * Space Complexity: O(N)
         *  -The stack can grow to the size of pushed/popped
         */
        public bool ValidateSequences(int[] pushed, int[] popped)
        {
            Stack<int> stack = new Stack<int>();

            int pushInd = 0;
            int popInd = 0;

            while (pushInd < pushed.Length)
            {
                if (stack.Count > 0 && stack.Peek() == popped[popInd])
                {
                    stack.Pop();
                    popInd++;
                }
                else
                {
                    stack.Push(pushed[pushInd]);
                    pushInd++;
                }
            }

            while (stack.Count > 0)
            {
                if (stack.Pop() != popped[popInd++])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
