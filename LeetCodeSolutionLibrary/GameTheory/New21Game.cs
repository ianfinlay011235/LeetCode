using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.GameTheory
{
    //https://leetcode.com/problems/new-21-game/

    public class New21Game
    {
        /*
         * Time Complexity: O()
         * Space Complexity: O()
         */
        public double NewGame(int n, int k, int maxPts)
        {
            int score = System.Math.Max(0, n - maxPts + 1);
            double probability = 1;
            while (score < k)
            {
                int invalidDraws = maxPts - System.Math.Min(n - score, maxPts);
                probability *= (double)invalidDraws / maxPts;
                score++;
            }
            return 1 - probability;
        }
    }
}
