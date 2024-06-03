using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.Arrays
{
    //https://leetcode.com/problems/maximum-subsequence-score/

    public class MaximumSubsequenceScore
    {
        /*
         * Time Complexity: O(n) where n is the length of nums1/nums2
         * Space Complexity: O(n) where n is equal to k: the size of the heap
         */
        public long MaxScore(int[] nums1, int[] nums2, int k)
        {
            long result;
            long sum = 0;
            PriorityQueue<int, int> heap = new PriorityQueue<int, int>();

            Array.Sort(nums2, nums1);

            for (int i = 1; i <= k; i++)
            {
                sum += nums1[^i];
                heap.Enqueue(nums1[^i], nums1[^i]);
            }
            result = sum * nums2[^k];

            for (int i = k + 1; i <= nums1.Length; i++)
            {
                sum = sum + nums1[^i] - heap.EnqueueDequeue(nums1[^i], nums1[^i]);
                result = Math.Max(result, sum * nums2[^i]);
            }

            return result;
        }
    }
}
