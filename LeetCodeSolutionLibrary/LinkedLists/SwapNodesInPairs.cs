using LeetCodeLibrary.DataStructures.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.LinkedLists
{
    //https://leetcode.com/problems/swap-nodes-in-pairs/

    public class SwapNodesInPairs
    {
        /*
         * Space Complexity: O(n)
         * Time Complexity: O(1)
         */

        public ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.Next == null) return head;

            ListNode dummy = new ListNode();

            ListNode previous = dummy;
            ListNode current = head;

            while (current != null && current.Next != null)
            {
                previous.Next = current.Next;
                current.Next = previous.Next.Next;
                previous.Next.Next = current;

                previous = current;
                current = current.Next;
            }

            return dummy.Next;
        }
    }
}
