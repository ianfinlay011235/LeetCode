using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary.Strings
{
    //https://leetcode.com/problems/string-to-integer-atoi/
    public class StringToInteger
    {
        public int MyAtoi(string s)
        {
            if (s.Length < 1) return 0;

            int sign = 1;
            int numBase = 0;
            int i = 0;

            while (i < s.Length && s[i] == ' ') i++;

            if (i == s.Length) return 0;

            if (s[i] == '-' || s[i] == '+')
            {
                sign = s[i] == '-' ? -1 : 1;
                i++;
            }
            while (i < s.Length && s[i] >= '0' && s[i] <= '9')
            {
                if (numBase > int.MaxValue / 10 || (numBase == int.MaxValue / 10 && s[i] - '0' > (sign == 1 ? 7 : 8)))
                {
                    if (sign == 1) return int.MaxValue;
                    else return int.MinValue;
                }
                numBase = 10 * numBase + (s[i++] - '0');
            }
            return numBase * sign;
        }
    }
}
