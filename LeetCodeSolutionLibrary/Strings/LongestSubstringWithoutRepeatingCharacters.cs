using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.Strings
{
    //https://leetcode.com/problems/longest-substring-without-repeating-characters/

    public class LongestSubstringWithoutRepeatingCharacters
    {
        /*
         * Time Complexity: O()
         * Space Complexity: O()
         */

        public int LengthOfLongestSubstring(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            int largest = 0;

            int i = 0;
            while (i < s.Length)
            {
                if (dict.ContainsKey(s[i]) == false)
                {
                    dict.Add(s[i], i);
                }
                else
                {
                    if (dict.Count > largest)
                    {
                        largest = dict.Count;
                    }

                    i = dict[s[i]] + 1;
                    dict.Clear();
                    dict.Add(s[i], i);
                }

                i++;
            }

            return System.Math.Max(largest, dict.Count);
        }
    }
}
