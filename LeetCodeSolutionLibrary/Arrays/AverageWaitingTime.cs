using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutionLibrary.Arrays
{
	//leetcode.com/problems/average-waiting-time

	public class AverageWaitingTime
	{
		/*
		 * Time Complexity: O(n) where n = customers.Length;
		 * Space Complexity: O(1)
		 */
		public double AverageWait(int[][] customers)
		{
			long preparingUntilTime = 0;
            long totalWaitTime = 0;

			foreach (var customer in customers)
			{
				if (preparingUntilTime <= customer[0])
				{
					preparingUntilTime = customer[0] + customer[1];
					totalWaitTime += customer[1];
				}
				else
				{
					preparingUntilTime += customer[1];
					totalWaitTime += preparingUntilTime - customer[0];
				}
			}

            return (double)totalWaitTime / customers.Length;
		}
	}
}