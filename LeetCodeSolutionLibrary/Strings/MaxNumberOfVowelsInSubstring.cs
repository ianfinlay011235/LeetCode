using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.Strings
{
    //https://leetcode.com/problems/maximum-number-of-vowels-in-a-substring-of-given-length/

    public class MaxNumberOfVowelsInSubstring
    {
        /*
         * Time Complexity: O(n)
         * Space Complexity: O(1)
         */
        public int MaxVowels(string s, int k)
        {
            string vowels = "aeiou";
            int max = 0;
            int current = 0;

            for (int i = 0; i <= s.Length - k; i++)
            {
                for (int j = i; j < i + k; j++)
                {
                    if (vowels.Contains(s[j])) current++;
                    //if current +/- rest of window ? < max break;
                }

                if (current > max) max = current;
                if (max == k) return max;

                current = 0;
            }

            return max;
        }
    }
}
