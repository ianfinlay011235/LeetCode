using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.Dictionaries
{
    public class RingsAndRods
    {
        public int CountPoints(string rings)
        {
            Dictionary<char, StringBuilder> rods = new Dictionary<char, StringBuilder>();
            char color;
            char label;
            for (int i = 0; i < rings.Length; i += 2)
            {
                color = rings[i];
                label = rings[i + 1];

                if (rods.ContainsKey(label))
                {
                    rods[label].Append(color);
                }
                else
                {
                    rods.Add(label, new StringBuilder(color.ToString()));
                }
            }

            int count = 0;
            foreach (var rod in rods)
            {
                string colors = rod.ToString();
                if (colors.Contains('R') && colors.Contains('G') && colors.Contains('B'))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
