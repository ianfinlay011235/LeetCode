using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary.Arrays
{
    //https://leetcode.com/problems/rotate-array/
    public class RotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            int n = nums.Length;

            if (n == 1)
            {
                return;
            }

            int[] rotated = new int[n];
            for (int i = 0; i < n; i++)
            {
                rotated[(i + k) % n] = nums[i];
            }

            for (int i = 0; i < n; i++)
            {
                nums[i] = rotated[i];
            }
        }
    }
}
