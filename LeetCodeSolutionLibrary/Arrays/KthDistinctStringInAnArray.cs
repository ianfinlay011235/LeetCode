using System.Collections.Generic;

namespace LeetCodeLibrary.Arrays
{
    //https://leetcode.com/problems/kth-distinct-string-in-an-array/
    public class KthDistinctStringInAnArray
    {
        public string KthDistinct(string[] arr, int k)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            foreach (var str in arr)
            {
                if (dictionary.ContainsKey(str) == false)
                {
                    dictionary.Add(str, 1);
                }
                else
                {
                    dictionary[str]++;
                }
            }

            int distinct = 0;
            foreach (var key in dictionary.Keys)
            {
                if (dictionary[key] == 1)
                {
                    distinct++;
                }
                if (distinct == k)
                {
                    return key;
                }
            }
            return "";
        }
    }
}
