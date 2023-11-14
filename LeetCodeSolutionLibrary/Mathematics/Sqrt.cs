using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.Mathematics
{
    public class Sqrt
    {
        public int MySqrt(int x)
        {
            if (x < 2) return x;
            int result = x/2;
            while (result * result > x)
            {
                result--;
            }
            return result;
        }
    }
}
