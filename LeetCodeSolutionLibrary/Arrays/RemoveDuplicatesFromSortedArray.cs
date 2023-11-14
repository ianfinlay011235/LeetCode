using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.Arrays
{
    //https://leetcode.com/problems/remove-duplicates-from-sorted-array/

    public class RemoveDuplicatesFromSortedArray
    {
        /*
         * Time Complexity: O(N)
         *  -N is the length of nums
         *  
         * Space Complexity: O(1)
         *  -Only the 2 index variables
         */

        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            
            int index = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[index] != nums[i])
                {
                    nums[++index] = nums[i];
                }
            }

            return index + 1;
        }
    }
}
