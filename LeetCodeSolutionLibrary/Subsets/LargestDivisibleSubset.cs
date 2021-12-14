using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary.Subsets
{
    public class LargestDivisibleSubset
    {
        public IList<int> LargestSubset(int[] nums)
        {
            Array.Sort(nums);
            var largestSubset = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var currentSubset = new List<int> { nums[i] };
                for (int j = 0; j < nums.Length; j++)
                {
                    if (j != i)
                    {
                        AddNumberToSubset(currentSubset, nums[j]);
                    }
                }
                if (currentSubset.Count > largestSubset.Count)
                {
                    largestSubset = currentSubset;
                }
            }
            return largestSubset;
        }

        private void AddNumberToSubset(IList<int> currentSub, int numToAdd)
        {
            for (int i = 0; i < currentSub.Count; i++)
            {
                if (currentSub[i] % numToAdd != 0 && numToAdd % currentSub[i] != 0)
                {
                    return;
                }
            }
            currentSub.Add(numToAdd);
        }
    }
}
