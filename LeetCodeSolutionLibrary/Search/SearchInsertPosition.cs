using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary.Search
{
    //https://leetcode.com/problems/search-insert-position/

    public class SearchInsertPosition
    {
        /*
         * Time Complexity: O(Log(N))
         *  - N is the length of nums
         *  
         * Space Complexity: O(1)
         */
        public int SearchInsert(int[] nums, int target)
        {
            int l = 0, r = nums.Length - 1;
            int mid;

            while (r >= l)
            {
                mid = l + (r - l) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }

                if (nums[mid] > target)
                {
                    r = mid - 1;
                }
                else
                {
                    l = mid + 1;
                }
            }

            return l;
        }
    }
}
