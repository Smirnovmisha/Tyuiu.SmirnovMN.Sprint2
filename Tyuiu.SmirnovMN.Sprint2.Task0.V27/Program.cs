using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SmirnovMN.Sprint2.Task0.V27.Lib;

namespace Tyuiu.SmirnovMN.Sprint2.Task0.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1305;
            int y = 275;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            Console.Title = "Спринт #1 | Выполнил: Смирнов М.Н| ИИПБ-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);


            for (int i = 0; i < 6; i++) ;
            {
                Console.WriteLine(res[i]); 
            }

            Console.ReadKey();

        }
    }
}
