using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary.Arrays
{
    //https://leetcode.com/problems/length-of-last-word/
    public class LengthOfWord
    {
        public int LengthOfLastWord(string s)
        {            
            int i = s.Length - 1, len = 0;
            while (s[i] == ' ')
            {
                i--;
            }
            while (i >= 0)
            {
                if (s[i] == ' ') break;
                i--;
                len++;
            }
            return len;

            //Slower one-liner solution:
            //return s.Trim().Split(' ').Last().Length;
        }
    }
}
