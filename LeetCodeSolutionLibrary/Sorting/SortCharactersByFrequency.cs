using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeLibrary.Sorting
{
    //https://leetcode.com/problems/sort-characters-by-frequency
    public class SortCharactersByFrequency
    {
        public string FrequencySort(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            StringBuilder output = new StringBuilder();

            foreach (char c in s)
            {
                dict[c] = dict.GetValueOrDefault(c) + 1;
            }

            foreach (var key in dict.Keys.OrderByDescending(k => dict[k]))
            {
                output.Append(new string(key, dict[key]));
            }

            return output.ToString();
        }
    }
}
