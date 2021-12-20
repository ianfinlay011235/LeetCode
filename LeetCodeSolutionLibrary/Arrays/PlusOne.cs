using System.Linq;

namespace LeetCodeSolutionLibrary.Arrays
{
    //https://leetcode.com/problems/plus-one/
    public class PlusOne
    {
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

            //while (digits[index] >= 9)
            //{
            //    if (index == 0)
            //    {
            //        if (digits[index] == 9)
            //        {
            //            return digits;
            //        }
            //        digits[index] = 0;
            //        return digits.Prepend(1).ToArray();
            //    }
            //    digits[index] = 0;
            //    digits[--index]++;
            //}
            //return digits;
        }
    }
}
