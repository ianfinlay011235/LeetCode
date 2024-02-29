using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.Strings
{
    public class RomanToInteger
    {
        public int RomanToInt(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };


            int output = 0;

            for (int i = 0; i < s.Length; i++)
            {
                //Subtraction instance
                if (i + 1 != s.Length && dict[s[i]] < dict[s[i + 1]])
                {
                    output += dict[s[i + 1]] - dict[s[i]];
                    i++;
                }
                //Normal instance
                else
                {
                    output += dict[s[i]];
                }
            }

            return output;
        }
    }
}
