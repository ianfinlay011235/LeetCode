using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.Strings
{
    //https://leetcode.com/problems/removing-stars-from-a-string/

    public class RemoveStarsFromAString
    {
        /*
         * Time Complexity: O(N)
         *  -N is the size of S
         *  
         * Space Complexity: O(N)
         *  -N is the size of S
         */

        public string RemoveStars(string s)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '*')
                {
                    sb.Remove(sb.Length - 1, 1);
                }
                else
                {
                    sb.Append(s[i]);
                }
            }

            return sb.ToString();
        }
    }
}
