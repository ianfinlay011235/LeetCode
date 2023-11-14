using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.Palindromes
{
    public class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            string input = x.ToString();
            int length = input.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (input[i] != input[input.Length - 1 - i]) return false;
            }
            return true;
        }
    }
}
