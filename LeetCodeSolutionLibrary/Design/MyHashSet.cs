using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.Design
{
    //https://leetcode.com/problems/design-hashset/

    public class MyHashSet
    {
        bool[] _set;

        public MyHashSet()
        {
            _set = new bool[1000001];
        }

        public void Add(int key)
        {
            _set[key] = true;
        }

        public void Remove(int key)
        {
            _set[key] = false;
        }

        public bool Contains(int key) => _set[key];
    }
}
