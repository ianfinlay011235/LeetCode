using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutionLibrary.Paths
{
    //https://leetcode.com/problems/minimum-score-of-a-path-between-two-cities/

    public class MinimumScorePath
    {
        public int MinScore(int n, int[][] roads)
        {
            var momento = new Dictionary<int, int>();

            ExplorePath(1, roads, momento);

            return momento.Select(m => m.Value).Min();
        }

        public void ExplorePath(int city, int[][] roads, Dictionary<int, int> momento)
        {
            if (momento.ContainsKey(city)) return;

            momento.Add(city, GetMinAdjacentRoadLength(city, roads));
            foreach (var road in roads.Where(r => r[0] == city || r[1] == city))
            {
                ExplorePath(road[0], roads, momento);
                ExplorePath(road[1], roads, momento);
            }
        }

        private int GetMinAdjacentRoadLength(int city, int[][] roads)
            =>roads.Where(r => r[0] == city || r[1] == city).Select(r => r[2]).Min();
    }
}
