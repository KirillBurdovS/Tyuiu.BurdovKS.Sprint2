



using System.ComponentModel.Design;
using Tyuiu.BurdovKS.Sprint2.Task5.V15.Lib;



class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();


  





        Console.Title = "Спринт #2 | Выполнил: Бурдов.К.С | СМАРТБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #15                                                             *");
        Console.WriteLine("* Выполнил: Бурдов Кирилл Сергеевич |  СМАРТБ-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая использует оператор switch                  *");
        Console.WriteLine("* вычисляет требуемое значение и возвращает результат.                    *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите номер дня: ");

        int numNedel = Convert.ToInt32(Console.ReadLine());


        string res;


        if ((numNedel < 1) || (numNedel > 365))
        {
            res = "Введенно неверное значение ";

        }
        else
        {
            res = "Этот день: " + ds.FindDayName(numNedel);
        }


        Console.WriteLine(res);

      





        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");


       





    }
}