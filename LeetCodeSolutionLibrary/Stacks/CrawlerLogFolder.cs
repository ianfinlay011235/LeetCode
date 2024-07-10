using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutionLibrary.Stacks
{
	//leetcode.com/problems/crawler-log-folder

	public class CrawlerLogFolder
	{
		/*
		 * Time Complexity: O(n) where n = logs.Length
		 * Space Complexity: O(1)
		 */
		public int MinOperations(string[] logs)
		{
			int operationsNeeded = 0;

			foreach (var log in logs)
			{
				switch (log)
				{
					case "../":
						if (operationsNeeded > 0) operationsNeeded--;
						break;
					case "./":
						break;
					default:
						operationsNeeded++;
						break;
				}
			}

			return operationsNeeded;
		}
	}
}