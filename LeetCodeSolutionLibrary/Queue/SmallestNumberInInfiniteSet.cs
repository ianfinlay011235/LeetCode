using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.Queue
{
    //https://leetcode.com/problems/smallest-number-in-infinite-set/

    public class SmallestNumberInInfiniteSet
    {
        private PriorityQueue<int, int> _pq;
        private int _smallest;

        public SmallestNumberInInfiniteSet()
        {
            _pq = new PriorityQueue<int, int>();
            _smallest = 1;
        }

        public int PopSmallest() =>
            _pq.Count > 0 ? _pq.Dequeue() : _smallest++;

        public void AddBack(int num)
        {
            if (num < _smallest)
            {
                _pq.Enqueue(num, num);
            }
        }
    }
}
