



using Tyuiu.BurdovKS.Sprint2.Task3.V22.Lib;


class Program
{
    static void Main(string[] args)
    {

        DataService ds= new DataService();


       


        Console.Title = "Спринт #2 | Выполнил: Бурдов.К.С | СМАРТБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #22                                                             *");
        Console.WriteLine("* Выполнил: Бурдов Кирилл Сергеевич |  СМАРТБ-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y      *");
        Console.WriteLine("* с использованием вложенных оператор if-else,                            *");
        Console.WriteLine("* где пользователь вводит значение переменной X с клавиатуры.             *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");


        Console.WriteLine("Введите значение перееменной X ");

        double x = Convert.ToDouble(Console.ReadLine());

        double res = ds.Calculate(x);







        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");


        Console.WriteLine(" Значение функции = " + res);





    }
}