using LeetCodeLibrary.DataStructures.LinkedList;

namespace LeetCodeLibrary.LinkedLists
{
    //https://leetcode.com/problems/remove-linked-list-elements/
    public class RemoveLinkedListElements
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null)
            {
                return head;
            }

            while (head?.Val == val)
            {
                head = head.Next;
            }

            ListNode temp = head;
            while (temp?.Next != null)
            {
                if (temp?.Next.Val == val)
                {
                    temp.Next = temp.Next.Next;
                }
                else
                {
                    temp = temp.Next;
                }
            }

            return head;
        }
    }
}
