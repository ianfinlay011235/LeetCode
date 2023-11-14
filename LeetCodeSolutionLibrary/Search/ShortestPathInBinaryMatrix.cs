using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.Search
{
    //Problem;
    //https://leetcode.com/problems/shortest-path-in-binary-matrix/

    //Assitance Solution:
    //https://leetcode.com/problems/shortest-path-in-binary-matrix/solutions/3584183/c-bfs-easy-to-understand/

    public class ShortestPathInBinaryMatrix
    {
        public int ShortestPathBinaryMatrix(int[][] grid)
        {
            if (grid[0][0] == 1) return -1;

            if (grid.Length == 1 && grid[0].Length == 1) return 1;

            var queue = new Queue<Tuple<Tuple<int, int>, int>>();
            queue.Enqueue(new Tuple<Tuple<int, int>, int>(new Tuple<int, int>(0, 0), 1));

            bool[][] visited = new bool[grid.Length][];
            for (int i = 0; i < grid.Length; i++)
            {
                visited[i] = new bool[grid[i].Length];
            }
            visited[0][0] = true;

            while (queue.Count > 0)
            {
                Tuple<int, int> coord = queue.Peek().Item1;
                int x = coord.Item1;
                int y = coord.Item2;
                int length = queue.Peek().Item2;
                queue.Dequeue();

                List<Tuple<int, int>> neighbours = new List<Tuple<int, int>> 
                {
                    new Tuple<int, int>(0, 1), 
                    new Tuple<int, int>(0, -1), 
                    new Tuple<int, int>(1, 0),
                    new Tuple<int, int>(-1, 0), 
                    new Tuple<int, int>(1, 1), 
                    new Tuple<int, int>(-1, -1),
                    new Tuple<int, int>(1, -1), 
                    new Tuple<int, int>(-1, 1)
                };

                foreach (var neighbour in neighbours)
                {
                    int newX = neighbour.Item1 + x;
                    int newY = neighbour.Item2 + y;

                    if (newX >= 0 && newY >= 0 && 
                        newX < grid.Length && newY < grid[0].Length && 
                        grid[newX][newY] == 0 && visited[newX][newY] == false)
                    {
                        queue.Enqueue(new Tuple<Tuple<int, int>, int>(new Tuple<int, int>(newX, newY), length + 1));
                        visited[newX][newY] = true;

                        if (newX == grid.Length - 1 && newY == grid.Length - 1)
                        {
                            return length + 1;
                        }

                    }
                }
            }

            return -1;
        }
    }
}
