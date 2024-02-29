using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutionLibrary.Dictionaries
{
	//https://leetcode.com/problems/unique-number-of-occurrences
	public class UniqueNumberOfOccurrences
	{
		public bool UniqueOccurences(int[] arr)
		{
			var dict = new Dictionary<int, int>();
            foreach (var num in arr)
            {
                if (!dict.ContainsKey(num))
                {
					dict.Add(num, 0);
                }
				dict[num]++;
            }
			return dict.Keys.Count == dict.Values.Distinct().Count();
		}
	}
}