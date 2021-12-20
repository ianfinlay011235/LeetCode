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
        public int SearchInsert(int[] nums, int target)
        {
            return BinarySearchHelper(nums, 0, nums.Length - 1, target);
        }

        private int BinarySearchHelper(int[] nums, int l, int r, int x)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;

                if (nums[mid] == x)
                {
                    return mid;
                }

                if (nums[mid] > x)
                {
                    return BinarySearchHelper(nums, l, mid - 1, x);
                }

                return BinarySearchHelper(nums, mid + 1, r, x); //else nums[mid] < x
            }

            return l;
        }
    }
}
