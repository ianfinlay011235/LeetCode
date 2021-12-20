using System;
using System.Collections.Generic;

namespace LeetCodeLibrary.Sums
{
    //https://leetcode.com/problems/3sum/
    public class ThreeSum
    {
        public IList<IList<int>> Three_Sum(int[] nums)
        {
            IList<IList<int>> output = new List<IList<int>>();
            //Array.Sort(nums);
            //for (int i = 0; i < nums.Length-2; i++)
            //{
            //    if (nums[i] > 0) break;
            //    int j = i + 1;
            //    int k = nums.Length - 1;
            //    while (j < k)
            //    {
            //        int sum = nums[i] + nums[j] + nums[k];
            //        if (sum == 0)
            //        {
            //            List<int> triplet = new List<int> { nums[i], nums[j], nums[k] };
            //            triplet.Sort();
            //            output.Add(triplet);
            //        }
            //        else if (sum > 0) k--;
            //        else if (sum < 0) j++;
            //    }
            //}
            return output;
        }
    }
}
