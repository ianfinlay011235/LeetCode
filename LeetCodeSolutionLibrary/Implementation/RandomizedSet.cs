using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeLibrary.Implementation
{
    //https://leetcode.com/problems/insert-delete-getrandom-o1/
    public class RandomizedSet
    {
        private readonly HashSet<int> _set;
        private readonly Random _rnd;

        public RandomizedSet()
        {
            _set = new HashSet<int>();
            _rnd = new Random();
        }

        public bool Insert(int val) => _set.Add(val);

        public bool Remove(int val) => _set.Remove(val);

        public int GetRandom() => _set.ElementAt(_rnd.Next(_set.Count));
    }
}
