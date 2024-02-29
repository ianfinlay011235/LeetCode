using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.Strings
{
    //https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/

    public class FindIndexOfFirstOccurence
    {
        /*
         * Time Complexity: O(N*M)
         *  -N is the length of haystack
         *  -M is the length of needle
         *  
         * Space Complexity: O(1)
         *  -The loop variables
         */
        public int StrStr(string haystack, string needle)
        {
            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                for (int j = 0; j < needle.Length; j++)
                {
                    if (haystack[i + j] != needle[j])
                    {
                        break;
                    }
                    else if (j + 1 == needle.Length)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }
    }
}
