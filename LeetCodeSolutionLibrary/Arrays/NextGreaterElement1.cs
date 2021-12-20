using System;
using System.Linq;

namespace LeetCodeLibrary.Arrays
{
    //https://leetcode.com/problems/next-greater-element-i/
    public class NextGreaterElement1
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            int[] ans = Enumerable.Repeat(-1, nums1.Length).ToArray();

            for (int i = 0; i < nums1.Length; i++)
            {
                int index = Array.IndexOf(nums2, nums1[i]);
                for (int j = index + 1; j < nums2.Length; j++)
                {
                    if (nums2[j] > nums2[index])
                    {
                        ans[i] = nums2[j];
                        break;
                    }
                }
            }

            return ans;
        }
    }
}
