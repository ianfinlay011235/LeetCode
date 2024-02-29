using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.Strings
{
    //https://leetcode.com/problems/merge-strings-alternately/

    public class MergeStringAlternately
    {
        /*
         * Time Complexity: O(MAX(N, M))
         * Space Complexity: O(MAX(N, M))
         *  -N is length of word1
         *  -M is length of word2
         */
        public string MergeAlternately(string word1, string word2)
        {
            StringBuilder output = new StringBuilder();
            int i = 0;
            while (i < word1.Length && i < word2.Length)
            {
                output.Append(word1[i]);
                output.Append(word2[i]);
                i++;
            }

            if (i >= word1.Length)
            {
                output.Append(word2.Substring(i));
            }
            else if (i >= word2.Length)
            {
                output.Append(word1.Substring(i));
            }

            return output.ToString();
        }
    }
}
