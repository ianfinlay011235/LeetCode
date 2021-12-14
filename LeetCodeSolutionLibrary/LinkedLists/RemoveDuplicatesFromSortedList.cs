using LeetCodeLibrary.DataStructures.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary.LinkedLists
{
    //https://leetcode.com/problems/remove-duplicates-from-sorted-list/
    public class RemoveDuplicatesFromSortedList
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null) return null;
            ListNode cur = head;
            while (cur.Next != null)
            {
                if (cur.Val == cur.Next.Val)
                {
                    cur.Next = cur.Next.Next;
                }
                else
                {
                    cur = cur.Next;
                }
            }
            return head;
        }
    }
}
