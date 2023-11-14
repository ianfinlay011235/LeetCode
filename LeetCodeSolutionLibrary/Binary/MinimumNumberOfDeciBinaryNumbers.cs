using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.Binary
{
    //https://leetcode.com/problems/partitioning-into-minimum-number-of-deci-binary-numbers/

    public class MinimumNumberOfDeciBinaryNumbers
    {
        /* Time Complexity: O(n)
         * Space Complexity: O(1)
         */
        public int MinPartitions(string n)
        {
            char max = '0';
            for (int i = 0; i < n.Length; i++)
            {
                if (max.CompareTo(n[i]) < 0)
                {
                    max = n[i];
                }
                if (max.CompareTo('9') == 0) break;
            }
            return max - '0';
        }
    }
}
