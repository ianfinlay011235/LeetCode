using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.Strings
{
    //https://leetcode.com/problems/longest-common-prefix/description/

    public class LongestCommonPrefix
    {
        /*
         * This is an optimized solution from:
         * https://leetcode.com/problems/longest-common-prefix/solutions/3174307/well-explained-code-using-strings-in-java/
         * 
         * Time Complexity: O(Nlog(N) + M)
         *  -Nlog(N) to sort the array
         *  -M iterating over the first and last strings
         *  
         * Space Complexity: O(1)
         */
        public string LongestCommonPref(string[] strs)
        {
            Array.Sort(strs);
            string first = strs[0];
            string last = strs[strs.Length - 1];
            int index = 0;
            while (index < first.Length && index < last.Length)
            {
                if (first[index] != last[index]) return first.Substring(0, index);
                index++;
            }
            return first.Substring(0, index);
        }

        /*
         * Below is my initial solution
         * 
         * Time Complexity: O(M*N) 
         *  - M is the length of the strs[0] 
         *  - N is the length of strs
         *  
         * Space Complexity: O(1)
         */

        //public string LongestCommonPref(string[] strs)
        //{
        //    int length = 0;
        //    for (int i = 0; i < strs[0].Length; i++)
        //    {
        //        foreach (var str in strs)
        //        {
        //            if (i >= str.Length || str[i] != strs[0][i])
        //            {
        //                return strs[0].Substring(0, length);
        //            }
        //        }
        //        length++;
        //    }
        //    return strs[0];
        //}
    }
}
