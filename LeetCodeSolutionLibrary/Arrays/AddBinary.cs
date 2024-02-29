using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary.Arrays
{
    //https://leetcode.com/problems/add-binary/
    //https://leetcode.com/problems/add-binary/discuss/24488/Short-AC-solution-in-Java-with-explanation
    public class AddBinary
    {
        public string Add(string a, string b)
        {
            StringBuilder sb = new StringBuilder();
            int i = a.Length - 1;
            int j = b.Length - 1;
            int carry = 0;
            while (i >= 0 || j >= 0)
            {
                int sum = carry;
                if (i >= 0) sum += a[i--] - '0';
                if (j >= 0) sum += b[j--] - '0';
                sb.Insert(0, sum % 2);
                carry = sum / 2;
            }
            if (carry != 0) sb.Insert(0, carry);
            return sb.ToString();
        }
    }
}
