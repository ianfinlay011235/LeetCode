using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutionLibrary.Arrays
{
	//https://leetcode.com/problems/hand-of-straights

	public class HandOfStraights
	{
		/*
		 * Time Complexity: O(n) where n = hand.length
		 * Space Complexity: O(n * m) where:
		 *  n = hand.length
		 *  m = groupszie
		 */
		public bool IsNStraightHand(int[] hand, int groupSize)
		{
            if (groupSize == 1)
            {
                return true;
            }

            if (hand.Length % groupSize != 0)
            {
				return false;
            }

			Dictionary<int, List<int>> dict = new();
			int groupCount;

            foreach (var card in hand)
            {
				//Preceding value doesn't exist so create new group
                if (!dict.ContainsKey(card - 1))
                {
                    if (!dict.ContainsKey(card))
                    {
						dict[card] = new List<int> { 1 };
					}
                    else
                    {
						dict[card].Add(1);
                    }
                }
                else
                {
                    /*
                     * -Remove the preceding card group from it's key
                     * -Increment the group's length
                     * -If the group's length is less than groupSize, add the group to the card's key
                     */

					groupCount = dict[card - 1][0];

                    dict[card - 1].RemoveAt(0);

                    groupCount++;

                    if (groupCount < groupSize)
                    {
                        if (!dict.ContainsKey(card))
                        {
							dict[card] = new List<int> { groupCount };
                        }
                        else
                        {
							dict[card].Add(groupCount);
                        }
                    }

                    if (dict[card - 1].Count < 1)
                    {
						dict.Remove(card - 1);
                    }
                }
            }

            return dict.Count < 1;
		}
	}
}