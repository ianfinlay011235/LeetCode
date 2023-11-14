using System.Linq;

namespace LeetCodeSolutionLibrary.Arrays
{
    //https://leetcode.com/problems/plus-one/
    public class PlusOne
    {
        /*
         * Time Complexity: O(N)
         *  -N is the length of digits
         * Space Complexity: O(N)
         *  -In the case where the integer being represented by the array
         *  is increased by a factor of 10, we need to create a new array
         *  the size of N + 1
         */
        public static int[] Plus1(int[] digits)
        {
            if (digits[digits.Length - 1] == 9)
            {
                digits[digits.Length - 1]++;
                for (int i = digits.Length - 1; i > 0; i--)
                {
                    if (digits[i] <= 9)
                    {
                        break;
                    }
                    digits[i] = 0;
                    digits[i - 1]++;
                }
                if (digits[0] > 9)
                {
                    digits[0] = 0;
                    digits = digits.Prepend(1).ToArray();
                }
            }
            else
            {
                digits[digits.Length - 1]++;
            }
            return digits;
        }
    }
}
