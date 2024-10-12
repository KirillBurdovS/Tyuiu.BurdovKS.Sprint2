

using Tyuiu.BurdovKS.Sprint2.Task2.V13.Lib;


class Program
{
    static void Main(string[] args)
    {
       



        Console.Title = "Спринт #2 | Выполнил: Бурдов.К.С | СМАРТБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #13                                                             *");
        Console.WriteLine("* Выполнил: Бурдов Кирилл Сергеевич |  СМАРТБ-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры  *");
        Console.WriteLine("* и вычисляет находится ли точка                                          *");
        Console.WriteLine("* с координатами X,Y в заштрихованной области                             *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");


        Console.WriteLine("Введите значение для пермененной X:");
        int x = Convert.ToInt32(Console.ReadLine());



        Console.WriteLine("Введите значение для пермененной Y:");
        int y = Convert.ToInt32(Console.ReadLine());



        DataService ds = new DataService();

        bool res = ds.CheckDotInShadedArea(x, y);


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");


        if (res)
        {
            Console.WriteLine("Точка лежит в заштрихованной области");
        }
        else
        {
            Console.WriteLine("Точка не лежит в заштрихованной области");


        }

        Console.ReadKey();




    }
    }
