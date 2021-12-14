using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary.DataStructures.LinkedList
{
    public static class ListHelper
    {
        public static ListNode BuildList(this int[] arr)
        {
            if (arr.Length < 1) return null;
            ListNode head = new ListNode(arr[0]);
            ListNode temp = head;
            for (int i = 1; i < arr.Length; i++)
            {
                temp.Next = new ListNode(arr[i]);
                temp = temp.Next;
            }
            return head;
        }

        public static int[] ToArray(this ListNode node)
        {
            int length = node.Length();
            int[] output = new int[length];
            for (int i = 0; i < length; i++)
            {
                output[i] = node.Val;
                node = node.Next;
            }
            return output;
        }

        public static int Length(this ListNode node)
        {
            if (node == null) return 0;
            int length = 0;
            while (node != null)
            {
                length++;
                node = node.Next;
            }
            return length;
        }
    }
}
