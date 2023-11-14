using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.Arrays
{
    //https://leetcode.com/problems/dota2-senate/

    public class Dota2Senate
    {
        /*
         * Time Complexity: O()
         * Space Complexity: O()
         */
        public string PredictPartyVictory(string senate)
        {
            Queue<int> radiant = new Queue<int>();
            Queue<int> dire = new Queue<int>();

            for (int i = 0; i < senate.Length; i++)
            {
                if (senate[i] == 'R') radiant.Enqueue(i);
                else dire.Enqueue(i);
            }

            int n = senate.Length;
            while (radiant.Count > 0 && dire.Count > 0)
            {
                if (radiant.Peek() < dire.Peek())
                {
                    radiant.Enqueue(n++);
                }
                else
                {
                    dire.Enqueue(n++);
                }
                dire.Dequeue();
                radiant.Dequeue();
            }

            return radiant.Count > 0 ? "Radiant" : "Dire";
        }
    }
}
