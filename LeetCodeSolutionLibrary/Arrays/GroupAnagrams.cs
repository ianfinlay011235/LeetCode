using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolutionLibrary.Strings
{
	//https://leetcode.com/problems/group-anagrams

	public class GroupAnagrams
	{
		/*
		 * Time Complexity: O(n * k) where n is the length of strs and k is the length of the longest string
		 * Space Complexity: O(n * k) where n is the length of strs and k is the length of the longest string
		 */
		public IList<IList<string>> GetGroupAnagrams(string[] strs)
		{
			List<IList<string>> groups = new List<IList<string>>();
			Dictionary<string, List<string>> sigMap = new Dictionary<string, List<string>>();

            foreach (var str in strs)
            {
				string sig = GetSignature(str);

				if (!sigMap.ContainsKey(sig))
                {
					sigMap[sig] = new List<string>();
                }

				sigMap[sig].Add(str);
            }

			groups.AddRange(sigMap.Values);

			return groups;
		}

		private string GetSignature(string str)
        {
			int[] count = new int[26];
            foreach (var ch in str)
            {
				count[ch - 'a']++;
            }

			StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 26; i++)
            {
				if (count[i] != 0)
				{
					sb.Append((char)('a' + i)).Append(count[i]);
				}
            }

			return sb.ToString();
        }
	}
}