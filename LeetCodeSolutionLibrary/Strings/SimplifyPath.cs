using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.Strings
{
    //https://leetcode.com/problems/simplify-path/

    public class SimplifyPath
    {
        /*
        * Time Complexity: O(N)
        *  -Where N is the size of path
        *  
        * Space Complexity: O(N)
        *  -Where N is the size of path
        */
        public string Simplify(string path)
        {
            List<string> output = new List<string>();

            var pathTokens = path.Split("/");

            for (int i = 0; i < pathTokens.Length; i++)
            {
                if (pathTokens[i] == "..")
                {
                    if (output.Count > 0)
                    {
                        output.RemoveAt(output.Count - 1);
                    }
                }
                else if (pathTokens[i] != "." && pathTokens[i] != "")
                {
                    output.Add(pathTokens[i]);
                }
            }

            return "/" + string.Join('/', output);
        }
    }
}
