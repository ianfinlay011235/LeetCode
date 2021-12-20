using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary.Strings
{
    //https://leetcode.com/problems/consecutive-characters/
    public class ConsecutiveCharacters
    {
        public int MaxPower(string s)
        {
            if (s == null || s.Length == 0) return 0;
            int max = 1;
            int cur = 1;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1])
                {
                    cur++;
                    if (cur > max)
                    {
                        max = cur;
                    }
                }
                else
                {
                    cur = 1;
                }
            }
            return max;
        }
    }
}
