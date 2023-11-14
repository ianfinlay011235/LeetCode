using LeetCodeLibrary.DataStructures.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.LinkedLists
{
    //https://leetcode.com/problems/maximum-twin-sum-of-a-linked-list/

    public class MaximumTwinSum
    {
        /*
         * Time Complexity: O(n)
         * Space Complexity: O(n)
         */
        public int PairSum(ListNode head)
        {
            Stack<int> stack = new Stack<int>();
            ListNode current = head;
            int max = 0;
            int length = 0;

            //Get list length
            while (current != null)
            {
                length++;
                current = current.Next;
            }
            current = head;

            //Find max sum
            for (int i = 0; i < length; i++)
            {
                if (i <= (length / 2) - 1) //First half of the list
                {
                    stack.Push(current.Val);
                }
                else //Second half of the list
                {
                    max = System.Math.Max(max, current.Val + stack.Pop());
                }
                current = current.Next;
            }

            return max;
        }
    }
}
