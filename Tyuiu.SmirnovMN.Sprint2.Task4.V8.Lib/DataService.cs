﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SmirnovMN.Sprint2.Task4.V8.Lib
{
    public class DataService : ISprint2Task4V8
    {
        public double Calculate(double x, double y)
        {
            double z = x * 2 > y + 15 ? (5 + Math.Pow(Math.Sqrt(y + 5) / Math.Pow(x, 3), 3)) : (2 * Math.Pow(x,2) + 2 * x - (4 + 6/Math.Pow(y,2)));
            return Math.Round(z, 2);
        }
    }
    
}
