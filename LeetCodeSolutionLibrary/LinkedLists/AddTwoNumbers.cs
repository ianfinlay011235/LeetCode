using LeetCodeLibrary.DataStructures.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.LinkedLists
{
    //https://leetcode.com/problems/add-two-numbers/

    public class AddTwoNumbers
    {
        /*
         * Time Complexity: O(max(N,M))
         * Space Complexity: O(max(N,M))
         *  -N is the length of l1
         *  -M is the length of l2
         */
        public ListNode Add(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode();
            ListNode temp = dummy;

            int carry = 0;
            while (l1 != null || l2 != null || carry == 1)
            {
                int sum = 0;
                if (l1 != null)
                {
                    sum += l1.Val;
                    l1 = l1.Next;
                }
                if (l2 != null)
                {
                    sum += l2.Val;
                    l2 = l2.Next;
                }
                sum += carry;
                carry = sum / 10;
                ListNode newNode = new ListNode(sum%10);
                temp.Next = newNode;
                temp = temp.Next;
            }

            return dummy.Next;
        }
    }
}
