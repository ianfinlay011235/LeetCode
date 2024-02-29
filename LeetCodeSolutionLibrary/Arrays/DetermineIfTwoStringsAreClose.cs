using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutionLibrary.Strings
{
	//https://leetcode.com/problems/determine-if-two-strings-are-close
	public class DetermineIfTwoStringsAreClose
	{
		public bool CloseStrings(string word1, string word2)
		{
			if (word1.Length != word2.Length) return false;

			var dict1 = new Dictionary<char, int>();
			var dict2 = new Dictionary<char, int>();

            foreach (var c in word1)
            {
                if (!dict1.ContainsKey(c))
                {
					dict1.Add(c, 0);
                }
				dict1[c]++;
            }

            foreach (var c in word2)
			{
				if (!dict2.ContainsKey(c))
				{
					dict2.Add(c, 0);
				}
				dict2[c]++;
			}

			return dict1.Keys.OrderBy(k => k).SequenceEqual(dict2.Keys.OrderBy(k => k))
				&& dict1.Values.OrderBy(c => c).SequenceEqual(dict2.Values.OrderBy(c => c));
		}
	}
}