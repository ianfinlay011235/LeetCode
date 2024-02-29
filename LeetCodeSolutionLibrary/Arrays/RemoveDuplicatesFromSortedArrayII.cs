using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutionLibrary.Arrays
{
	//https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii

	public class RemoveDuplicatesFromSortedArrayII
	{
		/*
		 * Time Complexity: O()
		 * Space Complexity: O()
		 */
		public int RemoveDuplicates(int[] nums)
		{
            if (nums.Length == 1) return 1;

			int num = nums[0];
			int count = 1;
			int head = 1;
			int tail = nums.Length - 1;

            while (head < tail)
            {
                if (nums[head] == num)
                {
                    count++;
                }
                else
                {
                    num = nums[head];
                    count = 1;
                }

                if (count > 2)
                {
                    int swap = head;
                    while (swap < tail)
                    {
                        int temp = nums[swap];
                        nums[swap] = nums[swap + 1];
                        nums[swap + 1] = temp;
                        swap++;
                    }
                    tail--;
                }
                else
                {
                    head++;
                }
            }

            if (nums[head] == num && count >= 2)
            {
                return head;
            }

            return head + 1;
		}
	}
}