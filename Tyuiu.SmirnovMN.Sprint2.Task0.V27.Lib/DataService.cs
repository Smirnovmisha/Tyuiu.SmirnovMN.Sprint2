using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
using Tyuiu.SmirnovMN.Sprint2.Task0.V27.Lib;

namespace Tyuiu.SmirnovMN.Sprint2.Task0.V27.Lib
{
    public class DataService : ISprint2Task0V27
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = y + 1030 == x;
            res[1] = x + y != 1580;
            res[2] = y < x;
            res[3] = y > x;
            res[4] = x <= y;
            res[5] = x + 2000 >= y;

            return res;
   
        }
    }
}
