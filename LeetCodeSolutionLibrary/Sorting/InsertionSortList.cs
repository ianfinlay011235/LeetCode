using LeetCodeLibrary.DataStructures.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.Sorting
{
    //https://leetcode.com/problems/insertion-sort-list/
    public class InsertionSortList
    {
        public ListNode InsertionSort(ListNode head)
        {
            if (head == null) return head;
            ListNode sHead = new ListNode(head.Val);
            ListNode sTail = sHead;
            ListNode cur, temp;

            head = head.Next;
            while (head != null)
            {
                if (head.Val <= sHead.Val) //Insert at the front of the list
                {
                    cur = new ListNode(head.Val);
                    cur.Next = sHead;
                    sHead = cur;
                }
                else if (head.Val >= sTail.Val) //Insert at the end of the list
                {
                    sTail.Next = new ListNode(head.Val);
                    sTail = sTail.Next;
                }
                else //Insert somewhere in the middle
                {
                    cur = sHead;
                    while (cur.Next.Val < head.Val)
                    {
                        cur = cur.Next;
                    }
                    temp = cur.Next;
                    cur.Next = new ListNode(head.Val);
                    cur = cur.Next;
                    cur.Next = temp;
                }
                head = head.Next;
            }
            return sHead;
        }
    }
}
