using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.Strings
{
    //https://leetcode.com/problems/length-of-last-word/

    public class LengthOfLastWord
    {
        /*
         * Time Complexity: O(N)
         *  -N is the length of s
         * Space Complexity: O(1)
         */
        public int LastWordLength(string s)
        {
            int length = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != ' ')
                {
                    length++;
                }
                else if (length > 0)
                {
                    return length;
                }
            }
            return length;
        }
    }
}
