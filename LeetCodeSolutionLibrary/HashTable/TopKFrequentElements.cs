using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.HashTable
{
    //https://leetcode.com/problems/top-k-frequent-elements/

    public class TopKFrequentElements
    {
        /*
         * Time Complexity: O(n * logn)
         * Space Complexity: O(n)
         */
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> frequencies = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (frequencies.ContainsKey(nums[i]) == false)
                {
                    frequencies.Add(nums[i], 1);
                }
                else
                {
                    frequencies[nums[i]]++;
                }
            }

            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
            foreach (var key in frequencies.Keys)
            {
                pq.Enqueue(key, frequencies[key]);
                if (pq.Count > k)
                {
                    pq.Dequeue();
                }
            }

            int[] output = new int[pq.Count];
            for (int i = 0; i < k; i++)
            {
                output[i] = pq.Dequeue();
            }

            return output;
        }
    }
}
