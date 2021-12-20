using LeetCodeLibrary.DataStructures.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary.LinkedLists
{
    //https://leetcode.com/problems/odd-even-linked-list/
    public class OddEvenLinkedList
    {
        public ListNode OddEvenList(ListNode head)
        {
            if (head == null)
            {
                return head;
            }

            ListNode odd = head;
            ListNode even = head.Next;
            ListNode evenHead = even;

            while (even != null && even.Next != null)
            {
                //add to odd list
                odd.Next = odd.Next.Next;
                odd = odd.Next;

                //add to even list
                even.Next = even.Next.Next;
                even = even.Next;
            }
            odd.Next = evenHead;
            return head;
        }
    }
}
