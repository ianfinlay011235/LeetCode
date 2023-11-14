using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.Arrays
{
    //https://leetcode.com/problems/find-the-difference-of-two-arrays/

    public class FindTheDifferenceOfTwoArrays
    {
        /*
         * Time Complexity: O()
         * Space Complexity: O()
         */
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
            => new List<IList<int>> { 
                new List<int>(nums1.Where(x => nums2.Contains(x) == false).Distinct()), 
                new List<int>(nums2.Where(x => nums1.Contains(x) == false).Distinct()) 
            };
    }
}
