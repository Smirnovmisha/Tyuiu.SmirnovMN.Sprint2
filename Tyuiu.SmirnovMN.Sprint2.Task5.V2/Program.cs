using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SmirnovMN.Sprint2.Task5.V2.Lib;

namespace Tyuiu.SmirnovMN.Sprint2.Task5.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Смирнов М.Н | ИИПБ-23-2";
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* Спринт #2                                               *");
            Console.WriteLine("* Тема: Оператор switch                                   *");
            Console.WriteLine("* Задание #5                                              *");
            Console.WriteLine("* Вариант #2                                             *");
            Console.WriteLine("* Выполнила: Смирнов Михаил Николаевич | ИИПБ-23-2        *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                 ");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("*Написать программу, которая по данному номеру месяца     *");
            Console.WriteLine("*определяет его название.                                 *");

            Console.WriteLine("***********************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
            Console.WriteLine("***********************************************************");

            Console.WriteLine("Введите номер месяца : ");
            int numMouth = Convert.ToInt32(Console.ReadLine());

            string res;
            if ((numMouth < 1) || (numMouth > 12))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = "Это месяц: " + ds.FindMonthSeason(numMouth);
            }



            Console.WriteLine("***********************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
            Console.WriteLine("***********************************************************");

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
