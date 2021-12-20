using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary.Arrays
{
    //https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/
    public class FindAllNumbersDisappearedInAnArray
    {
        //public IList<int> FindDisappearedNumbers(int[] nums)
        //{
        //    List<int> output = new List<int>();
        //    for (int i = 1; i <= nums.Length; i++)
        //    {
        //        if (nums.Contains(i) == false)
        //        {
        //            output.Add(i);
        //        }
        //    }
        //    return output;
        //}

        //Solution - III (HashSet)
        //https://tinyurl.com/5a4xrcsp
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            HashSet<int> set = new HashSet<int>(nums);
            List<int> output = new List<int>();
            for (int i = 1; i <= nums.Length; i++)
            {
                if (set.Contains(i) == false)
                {
                    output.Add(i);
                }
            }
            return output;
        }
    }
}
