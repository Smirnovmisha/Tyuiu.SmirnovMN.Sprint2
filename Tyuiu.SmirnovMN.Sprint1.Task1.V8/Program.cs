﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SmirnovMN.Sprint1.Task1.V8.Lib;

namespace Tyuiu.SmirnovMN.Sprint1.Task1.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int a = 15;
            int b = 16;
            int c = 14;
            int d = 335;

            bool[] res = new bool[6];
            res = ds.GetLogicOperation(a, b, c, d);

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("**********************************************************************************");]

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                     *");
            Console.WriteLine("**********************************************************************************");

            for (int i = 0; i < 6, i++) ;
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();

        }
    }
}
