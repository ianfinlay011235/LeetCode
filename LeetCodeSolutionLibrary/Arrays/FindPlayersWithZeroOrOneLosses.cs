using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutionLibrary.Arrays
{
	//https://leetcode.com/problems/find-players-with-zero-or-one-losses/description/
	public class FindPlayersWithZeroOrOneLosses
	{
		public IList<IList<int>> FindWinners(int[][] matches)
		{
			var players = new Dictionary<int, int>();

            foreach (var match in matches)
            {
                if (!players.ContainsKey(match[0]))
                {
					players.Add(match[0], 0);
                }
                if (!players.ContainsKey(match[1]))
                {
                    players.Add(match[1], 0);
                }
                players[match[1]]++;
            }

            return 
                new List<IList<int>> 
                { 
                    new List<int>(players.Where(p => p.Value == 0).Select(p => p.Key).OrderBy(p => p)),
                    new List<int>(players.Where(p => p.Value == 1).Select(p => p.Key).OrderBy(p => p))
                };
        }
	}
}