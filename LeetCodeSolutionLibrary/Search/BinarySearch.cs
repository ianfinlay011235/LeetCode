using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary.Search
{
    public class BinarySearch
    {
        public int Search(int[] nums, int target)
        {
            int lo = 0;
            int mid;
            int hi = nums.Length - 1;

            while (lo <= hi)
            {
                mid = lo + (hi - lo) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] > target)
                {
                    hi = mid - 1;
                }
                else
                {
                    lo = mid + 1;
                }
            }
            return -1;
        }
    }
}
