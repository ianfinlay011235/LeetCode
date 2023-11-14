using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.Tree
{
    //https://leetcode.com/problems/time-needed-to-inform-all-employees/

    //public class TimeNeededToInformAllEmployees
    //{
    //    int _maxTime = -1;

    //    public void Dfs(int[] manager, int[] informTime, int id, int time)
    //    {
    //        //int[] subordinates = manager.Select((sub, i) => sub == id ? i : -1).Where(i => i != -1 && informTime[i] != 0).ToArray();
    //        List<int> subordinates = new List<int>();
    //        for (int i = 0; i < manager.Length; i++)
    //        {
    //            if (manager[i] == id && informTime[i] != 0)
    //            {
    //                subordinates.Add(i);
    //            }
    //        }

    //        if (subordinates.Length == 0)
    //        {
    //            _maxTime = Math.Max(_maxTime, time);
    //            return;
    //        }

    //        for (int i = 0; i < subordinates.Length; i++)
    //        {
    //            Dfs(manager, informTime, subordinates[i], time + informTime[subordinates[i]]);
    //        }
    //    }

    //    public int NumOfMinutes(int n, int headID, int[] manager, int[] informTime)
    //    {
    //        Dfs(manager, informTime, headID, informTime[headID]);

    //        return _maxTime;
    //    }
    //}
}
