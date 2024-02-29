using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeLibrary.Sums
{
    //https://leetcode.com/problems/3sum/

    public class ThreeSum
    {
        public IList<IList<int>> Three_Sum(int[] nums)
        {
            IList<IList<int>> output = new List<IList<int>>();

            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (nums[i] > 0)
                {
                    break;
                }

                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                int low = i + 1;
                int high = nums.Length - 1;

                while (low < high)
                {
                    int sum = nums[i] + nums[low] + nums[high];

                    if (sum > 0)
                    {
                        high--;
                    }
                    else if (sum < 0)
                    {
                        low++;
                    }
                    else
                    {
                        output.Add(new List<int> { nums[i], nums[low], nums[high] });

                        int lastLow = nums[low];
                        int lastHigh = nums[high];

                        while (low < high && lastLow == nums[low])
                        {
                            low++;
                        }

                        while (low < high && lastHigh == nums[high])
                        {
                            high--;
                        }
                    }
                }
            }

            return output;
        }
    }
}
