using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.Strings
{
    public class OptimalPartitionString
    {
        public int PartitionString(string s)
        {
            HashSet<int> set = new HashSet<int>();
            int partitions = 1;
            int length = s.Length;

            for (int i = 0; i < length; i++)
            {
                if (set.Add(s[i]) == false)
                {
                    partitions++;
                    set.Clear();
                    set.Add(s[i]);
                }
            }
            return partitions;
        }
    }
}
