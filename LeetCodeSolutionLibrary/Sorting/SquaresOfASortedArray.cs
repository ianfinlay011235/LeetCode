using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary.Sorting
{
    public class SquaresOfASortedArray
    {
        public int[] SortedSquares(int[] nums)
        {
            int n = nums.Length;
            int[] results = new int[n];
            int i = 0;
            int j = n - 1;
            for (int k = n - 1; k >= 0; k--)
            {
                if (Math.Abs(nums[i]) > Math.Abs(nums[j]))
                {
                    results[k] = nums[i] * nums[i];
                    i++;
                }
                else
                {
                    results[k] = nums[j] * nums[j];
                    j--;
                }
            }
            return results;
        }

        //A solution that's faster but does not implement the intended two-pointer solution
        //public int[] SortedSquares(int[] nums)
        //{
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        nums[i] *= nums[i];
        //    }
        //    Array.Sort(nums);
        //    return nums;
        //}
    }
}
