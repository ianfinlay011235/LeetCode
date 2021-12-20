using LeetCodeLibrary.DataStructures.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary.Stacks
{
    //https://leetcode.com/problems/convert-binary-number-in-a-linked-list-to-integer/
    public class ConvertBinaryToInteger
    {
        //my solution
        public int GetDecimalValue(ListNode head)
        {
            Stack<int> stack = new Stack<int>();
            while (head != null)
            {
                stack.Push(head.Val);
                head = head.Next;
            }

            int val = 1;
            int res = 0;
            while (stack.Count > 0)
            {
                if (stack.Pop() == 1)
                {
                    res += val;
                }
                val *= 2;
            }
            return res;
        }

        //more efficient solution
        public int GetEfficientDecimalValue(ListNode head)
        {
            int res = 0;

            while (head != null)
            {
                res = res << 1 | head.Val;   // res = res*2 + head.val;
                head = head.Next;
            }

            return res;
        }
    }
}
