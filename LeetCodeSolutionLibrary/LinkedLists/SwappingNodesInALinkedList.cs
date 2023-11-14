using LeetCodeLibrary.DataStructures.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.LinkedLists
{
    //https://leetcode.com/problems/swapping-nodes-in-a-linked-list/

    public class SwappingNodesInALinkedList
    {
        /*
         * Time Complexity: O(N)
         * Space Complexity: O(1)
         */
        public ListNode SwapNodes(ListNode head, int k)
        {
            ListNode node1 = null;
            ListNode node2 = null;

            ListNode current = head;
            int length = 0;
            while (current != null)
            {
                length++;
                current = current.Next;
            }

            current = head;
            for (int i = 1; i <= length; i++)
            {
                if (i == k)
                {
                    node1 = current;
                }
                if (i == length - k + 1)
                {
                    node2 = current;
                }
                if (node1 != null && node2 != null)
                {
                    break;
                }
                current = current.Next;
            }

            int val = node1.Val;
            node1.Val = node2.Val;
            node2.Val = val;

            return head;
        }
    }
}
