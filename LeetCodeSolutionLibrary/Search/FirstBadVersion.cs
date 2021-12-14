using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary.Search
{
    public class FirstBadVersion
    {
        public FirstBadVersion(int bad)
        {
            _bad = bad;
        }

        private int _bad;

        public int FindBadVersion(int n)
        {
            int l = 0;
            int r = n - 1;
            int mid;
            while (r >= l)
            {
                mid = l + (r - l) / 2;
                if (IsBadVersion(mid))
                {
                    r = mid - 1;
                }
                else
                {
                    l = mid + 1;
                }
            }
            return r + 1;
        }

        private bool IsBadVersion(int i)
        {
            return i >= _bad;
        }
    }
}
