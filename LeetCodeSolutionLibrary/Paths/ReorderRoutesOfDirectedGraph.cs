using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.Paths
{
    //https://leetcode.com/problems/reorder-routes-to-make-all-paths-lead-to-the-city-zero/
    public class ReorderRoutesOfDirectedGraph
    {
        public int MinReorder(int n, int[][] connections)
        {
            int reorderCount = 0;
            List<int[]> connectionList = connections.ToList();

            foreach (var connection in connections.Where(c => c[0] == 0 || c[1] == 0))
            {
                MinReorder(connectionList, 0, connection, ref reorderCount);
            }
            return reorderCount;
        }

        public void MinReorder(List<int[]> connections, int city, int[] connection, ref int reorderCount)
        {
            if (connection[1] != city) reorderCount++;
            connections.Remove(connection);

            int nextCity = connection[0] == city ? connection[1] : connection[0];
            foreach (var nextConnection in connections.Where(c => c[0] == nextCity || c[1] == nextCity))
            {
                MinReorder(connections, nextCity, nextConnection, ref reorderCount);
            }
        }
    }
}
