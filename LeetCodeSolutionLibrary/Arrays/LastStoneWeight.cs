using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.Arrays
{
    //https://leetcode.com/problems/last-stone-weight/

    public class LastStoneWeight
    {
        /*
         * Time Complexity: O(nlogn)
         * Space Complexity: O(n)
         *  -N is the length of stones
         */
        public int LastWeight(int[] stones)
        {
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>(stones.Select(x => (x, -x))); //n + log n

            while (pq.Count > 1)
            {
                int stone1 = pq.Dequeue(); //n * log n
                int stone2 = pq.Dequeue();
                if (stone1 != stone2)
                {
                    stone1 = stone1 - stone2;
                    pq.Enqueue(stone1, -stone1); 
                }
            }

            return pq.Count > 0 ? pq.Dequeue() : 0;
        }
    }
}
