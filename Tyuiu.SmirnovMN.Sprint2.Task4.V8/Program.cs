﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SmirnovMN.Sprint2.Task4.V8.Lib;


namespace Tyuiu.SmirnovMN.Sprint2.Task4.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2| Выполнил: Смирнов М. Н. | ИИПб-23-2";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #2                                                                    *");
            Console.WriteLine("* Тема: Тернарный оператор                                                     *");
            Console.WriteLine("* Задание #4                                                                   *");
            Console.WriteLine("* Вариант #8                                                                   *");
            Console.WriteLine("* Выполнил: Смирнов М. Н. | ИИПб-23-2                                          *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение использованием      *");
            Console.WriteLine("* тернарного оператора, где пользователь ВВОДИТ значение переменных х, у       *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("Введите значение переменной X:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение переменной Y:");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");

            double result = ds.Calculate(x, y);
            Console.WriteLine($"При x = {x} и y = {y}, значение функции = " + result);
            Console.ReadKey();
        }
    }
}
