using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary.Strings
{
    //https://leetcode.com/problems/zigzag-conversion/
    public class ZigZagConversion
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1)
            {
                return s;
            }

            StringBuilder[] sb = new StringBuilder[numRows];
            for (int sbIndex = 0; sbIndex < numRows; sbIndex++)
            {
                sb[sbIndex] = new StringBuilder();
            }

            int i = 0;
            int len = s.Length;
            while (i < len)
            {
                for (int sbIndex = 0; sbIndex < numRows && i < len; sbIndex++) //down
                {
                    sb[sbIndex].Append(s[i++]);
                }
                for (int sbIndex = numRows - 2; sbIndex >= 1 && i < len; sbIndex--) //up
                {
                    sb[sbIndex].Append(s[i++]);
                }
            }

            for (int sbIndex = 1; sbIndex < sb.Length; sbIndex++)
            {
                sb[0].Append(sb[sbIndex].ToString());
            }
            return sb[0].ToString();
        }
    }
}
