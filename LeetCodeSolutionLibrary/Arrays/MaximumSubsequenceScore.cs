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
         * Time Complexity: O()
         * Space Complexity: O()
         */
        public long MaxScore(int[] nums1, int[] nums2, int k)
        {
            int n = nums1.Length;
            int[][] pairs = new int[n][];
            for (int i = 0; i < n; i++)
            {
                pairs[i] = new int[] { nums1[i], nums2[i] };
            }
            //Array.Sort(pairs, (a, b) => a[0] - b[0]);
            pairs = pairs.OrderBy(x => x[0] - x[1]).ToArray();
            
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
            long res = 0;
            long totalSum = 0;
            for (int i = 0; i < n; i++)
            {
                pq.Enqueue(pairs[i][0], pairs[i][0] - pairs[i][1]);
                totalSum += pairs[i][0];
                if (pq.Count > k)
                {
                    totalSum -= pq.Dequeue();
                }
                if (pq.Count == k)
                {
                    res = System.Math.Max(res, totalSum * pairs[i][1]);
                }
            }
            return res;
        }
    }
}
