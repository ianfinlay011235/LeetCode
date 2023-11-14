using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.Design
{
    //https://leetcode.com/problems/design-underground-system/

    public class UndergroundSystem
    {
        Dictionary<string, object[]> _tripData;
        Dictionary<int, Tuple<string, int>> _currentTrips;

        public UndergroundSystem()
        {
            _tripData = new Dictionary<string, object[]>();
            _currentTrips = new Dictionary<int, Tuple<string, int>>();
        }

        public void CheckIn(int id, string stationName, int t)
        {
            _currentTrips.Add(id, new Tuple<string, int>(stationName, t));
        }

        public void CheckOut(int id, string stationName, int t)
        {
            string tripKey = $"{_currentTrips[id].Item1}-{stationName}";
            double tripLength = t - _currentTrips[id].Item2;

            if (_tripData.ContainsKey(tripKey) == false)
            {
                _tripData.Add(tripKey, new object[] { tripLength, 1 });
            }
            else
            {
                _tripData[tripKey][0] = (double)_tripData[tripKey][0] + tripLength;
                _tripData[tripKey][1] = (int)_tripData[tripKey][1] + 1;
            }

            _currentTrips.Remove(id);
        }

        public double GetAverageTime(string startStation, string endStation)
        {
            string tripKey = $"{startStation}-{endStation}";
            double totalTripTime = (double)_tripData[tripKey][0];
            int tripCount = (int)_tripData[tripKey][1];

            return (double)(totalTripTime / tripCount);
        }
    }
}
