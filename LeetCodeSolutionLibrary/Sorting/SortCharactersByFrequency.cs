using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeLibrary.Sorting
{
    //https://leetcode.com/problems/sort-characters-by-frequency/submissions/
    public class SortCharactersByFrequency
    {
        public string FrequencySort(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict.Add(c, 1);
                }
            }
            StringBuilder output = new StringBuilder();
            foreach (var key in dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value).Keys)
            {
                output.Append(new string(key, dict[key]));
            }
            return output.ToString();
        }
    }
}
