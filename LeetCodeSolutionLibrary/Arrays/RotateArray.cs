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
            // this only works when n is odd
            int n = nums.Length;
            if (n == 1) return;
            int t1;
            int t2 = nums[0];
            int cur = 0;
            for (int i = 0; i < n; i++)
            {
                cur = (cur + k) % n;
                t1 = nums[cur];
                nums[cur] = t2;
                t2 = t1;
            }
        }

        //Solution too slow
        //public void Rotate(int[] nums, int k)
        //{
        //    int n = nums.Length;
        //    if (n == 1) return;

        //    int t1;
        //    int t2;

        //    for (int i = 0; i < k; i++)
        //    {
        //        t1 = nums[0];
        //        t2 = nums[1];
        //        for (int j = 0; j < n - 2; j++)
        //        {
        //            nums[j + 1] = t1;
        //            t1 = t2;
        //            t2 = nums[j + 2];
        //        }
        //        nums[n - 1] = t1;
        //        nums[0] = t2;
        //    }
        //}
    }
}
