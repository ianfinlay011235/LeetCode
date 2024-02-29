using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutionLibrary.Dictionaries
{
	//https://leetcode.com/problems/find-the-town-judge

	public class FindTheTownJudge
	{
		/*
		 * Time Complexity: O(n) where n is the size of trust
		 * Space Complexity: O(n) where n is the size of trust
		 */
		public int FindJudge(int n, int[][] trust)
		{
			if (n == 1) return 1;

			Dictionary<int, int> trusted = new Dictionary<int, int>();

            foreach (var relationship in trust)
            {
				trusted[relationship[1]] = trusted.GetValueOrDefault(relationship[1], 0) + 1;
				trusted[-relationship[0]] = 0;
            }

            if (trusted.ContainsValue(n - 1))
            {
				int key = trusted.First(kvp => kvp.Value == n - 1).Key;
                if (!trusted.ContainsKey(-key))
                {
					return key;
                }

			}

			return -1;
		}
	}
}