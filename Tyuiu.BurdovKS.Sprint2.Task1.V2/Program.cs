﻿

using Tyuiu.BurdovKS.Sprint2.Task1.V2.Lib;


class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();


        int a = 135;

        int b = 156;

        int c = 154;

        int d = 174;

        bool[] res = new bool[6];



        res = ds.GetLogicOperations(a, b, c, d);




        Console.Title = "Спринт #2 | Выполнил: Бурдов.К.С | СМАРТБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #2                                                              *");
        Console.WriteLine("* Выполнил: Бурдов Кирилл Сергеевич |  СМАРТБ-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу из операций сравнений  и  логических операций,       *");
        Console.WriteLine("* а также арифметических выражений,                                       *");
        Console.WriteLine("* которая вернет логическую последовательность(массив)                    *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");


        Console.WriteLine("A = " + a);
        Console.WriteLine("B = " + b);
        Console.WriteLine("C = " + c);
        Console.WriteLine("D = " + d);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(res[i]);

            Console.ReadKey();


        }
    }
}
