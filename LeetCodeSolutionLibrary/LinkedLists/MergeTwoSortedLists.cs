using LeetCodeLibrary.DataStructures.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.LinkedLists
{
    public class MergeTwoSortedLists
    {
        /*
         * Time Complexity: O(M + N)
         *  -M is the size of list1
         *  -N is the size of list2
         *  
         * Space Complexity: O(1)
         *  -Using the pre-existing ListNode's and just changing the pointers
         */
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null) return list2;
            if (list2 == null) return list1;

            ListNode head;
            if (list1.Val < list2.Val)
            {
                head = list1;
                list1 = list1.Next;
            }
            else
            {
                head = list2;
                list2 = list2.Next;
            }

            ListNode node = head;
            while (list1 != null && list2 != null)
            {
                if (list1.Val < list2.Val)
                {
                    node.Next = list1;
                    list1 = list1.Next;
                }
                else
                {
                    node.Next = list2;
                    list2 = list2.Next;
                }
                node = node.Next;
            }

            if (list1 == null)
            {
                node.Next = list2;
            }
            else if (list2 == null)
            {
                node.Next = list1;
            }

            return head;
        }
    }
}
