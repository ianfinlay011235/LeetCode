using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutionLibrary.Sorting
{
	//leetcode.com/problems/minimum-number-of-moves-to-seat-everyone

	public class MinimumNumberOfMovesToSeatEveryone
	{
		/*
		 * Time Complexity: O()
		 * Space Complexity: O()
		 */
		public int MinMovesToSeat(int[] seats, int[] students)
		{
			Array.Sort(seats);
			Array.Sort(students);

			int moves = 0;
			int n = seats.Length;
			int i = 0;

            while (i < n)
            {
                if (seats[i] == students[i])
                {
					i++;
                }
				else if (seats[i] < students[i])
                {
					students[i]--;
					moves++;
                }
                else //seats[i] > students[i]
                {
					students[i]++;
					moves++;
                }
            }

			return moves;
		}
	}
}