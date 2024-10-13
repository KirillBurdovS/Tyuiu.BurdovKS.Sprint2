


using Tyuiu.BurdovKS.Sprint2.Task4.V13.Lib;




class Program
{
    static void Main(string[] args)
    {

        DataService ds = new DataService();





        Console.Title = "Спринт #2 | Выполнил: Бурдов.К.С | СМАРТБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #13                                                             *");
        Console.WriteLine("* Выполнил: Бурдов Кирилл Сергеевич |  СМАРТБ-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет требуемое значение                *");
        Console.WriteLine("* с использованием тернарного оператора                                   *");
        Console.WriteLine("* где пользователь вводит значение переменной X, Y с клавиатуры.          *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");


        Console.WriteLine("Введите значение перееменной X ");

        double x = Convert.ToDouble(Console.ReadLine());

       


        Console.WriteLine("Введите значение перееменной Y ");

        double y = Convert.ToDouble(Console.ReadLine());


        double res = ds.Calculate(x, y);






        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");


        Console.WriteLine(" Значение функции = " + res);





    }
}