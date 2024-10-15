


using Tyuiu.BurdovKS.Sprint2.Task6.V14.Lib;


class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();








        Console.Title = "Спринт #2 | Выполнил: Бурдов.К.С | СМАРТБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Получение результата из switch                                    *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #14                                                             *");
        Console.WriteLine("* Выполнил: Бурдов Кирилл Сергеевич |  СМАРТБ-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дано целое число k (1 <= k <= 365). Определить, каким днем недели       *");
        Console.WriteLine("* является k-й день не високосного года,                                  *");
        Console.WriteLine("* в котором 1 января d-й день недели                                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите число от 1 до 365:");
        int k = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите число от 1 до 7:");
        int d = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        try
        {
            string day = ds.FindDayName(k, d);
            Console.WriteLine(day);
        }
        catch
        {
            Console.WriteLine("Неверно");
        }
        Console.ReadKey();

        int res;
    }
}




