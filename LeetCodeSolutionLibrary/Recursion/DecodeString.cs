using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.Recursion
{
    //https://leetcode.com/problems/decode-string/
    public class DecodeString
    {
        public string Decode(string s)
        {
            Stack<char> stack = new Stack<char>();
            string result = "";
            int i = 0;
            int count = 0;
            int lo = 0;
            while (i < s.Length)
            {
                if (char.IsDigit(s[i]) && stack.Count == 0)
                {
                    count = s[i] - '0';
                    while (char.IsDigit(s[i + 1]))
                    {
                        count = count * 10 + s[++i] - '0';
                    }
                    lo = i + 2;
                }
                else if (s[i] == '[')
                {
                    stack.Push('[');
                }
                else if (s[i] == ']')
                {
                    stack.Pop();
                    if (stack.Count == 0)
                    {
                        string sub = Decode(s.Substring(lo, i - lo));
                        for (int j = 0; j < count; j++)
                        {
                            result += sub;
                        }
                        //result += string.Join(
                        //    "", Enumerable.Repeat(Decode(s.Substring(lo, i - lo)), count));
                    }
                }
                else if (stack.Count == 0)
                {
                    result += s[i];
                }
                i++;
            }
            return result;
        }
    }
}
