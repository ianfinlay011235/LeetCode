using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary.Arrays
{
    //https://leetcode.com/problems/longest-palindromic-substring/
    //Solution from user <jinwu> https://leetcode.com/problems/longest-palindromic-substring/discuss/2928/Very-simple-clean-java-solution
    public class LongestPalindromicSubstring
    {
        private int _lo;
        private int _maxLen;

        public string LongestPalindrome(string s)
        {
            int len = s.Length;
            if (len < 2)
            {
                return s;
            }
            for (int i = 0; i < len - 1; i++)
            {
                ExtendPalindrome(s, i, i); //Assume odd length, try to extend Palidrome if possible
                ExtendPalindrome(s, i, i + 1); //Assume even length.
            }
            return s.Substring(_lo, _maxLen);
        }

        private void ExtendPalindrome(string s, int j, int k)
        {
            while (j >= 0 && k < s.Length && s[j] == s[k])
            {
                j--;
                k++;
            }
            if (_maxLen < k - j - 1)
            {
                _lo = j + 1;
                _maxLen = k - j - 1;
            }
        }
    }
}
