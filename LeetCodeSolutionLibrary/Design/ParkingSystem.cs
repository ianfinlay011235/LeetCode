using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.Design
{
    //https://leetcode.com/problems/design-parking-system/

    public class ParkingSystem
    {
        int _big, _medium, _small;

        public ParkingSystem(int big, int medium, int small)
        {
            _big = big;
            _medium = medium;
            _small = small;
        }

        public bool AddCar(int carType)
        {
            switch (carType)
            {
                case 1:
                    if (_big == 0) return false;
                    else _big--;
                    break;
                case 2:
                    if (_medium == 0) return false;
                    else _medium--;
                    break;
                case 3:
                    if (_small == 0) return false;
                    else _small--;
                    break;
            }
            return true;
        }
    }
}
