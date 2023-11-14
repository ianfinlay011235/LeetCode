using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.Queue
{
    //https://leetcode.com/problems/kth-largest-element-in-a-stream/

    public class KthLargestElementInAStream
    {
        PriorityQueue<int, int> _heap;
        int _k;

        /*
         * Time Complexity: O()
         * Space Complexity: O()
         */
        public KthLargestElementInAStream(int k, int[] nums)
        {
            _heap = new PriorityQueue<int, int>();
            _k = k;
            for (int i = 0; i < nums.Length; i++) Add(nums[i]);
        }

        public int Add(int val)
        {
            _heap.Enqueue(val, val);
            if (_heap.Count > _k)
            {
                _heap.Dequeue();
            }
            return _heap.Peek();
        }
    }
}
