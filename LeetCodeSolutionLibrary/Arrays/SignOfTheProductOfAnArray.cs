using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.Arrays
{
    //https://leetcode.com/problems/sign-of-the-product-of-an-array/

    public class SignOfTheProductOfAnArray
    {
        /*
         * Time Complexity: O(n)
         * Space Complexity: O(1)
         */
        public int ArraySign(int[] nums)
        {
            if (nums[0] == 0) return 0;
            bool isPos = nums[0] > 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == 0) return 0;
                isPos = (isPos && nums[i] > 0) || (!isPos && nums[i] < 0);
            }
            return isPos ? 1 : -1;
        }
    }
}
