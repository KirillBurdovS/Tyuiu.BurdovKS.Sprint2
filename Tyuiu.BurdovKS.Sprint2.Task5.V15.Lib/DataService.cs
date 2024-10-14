


using System.Data;
using tyuiu.cources.programming.interfaces.Sprint2;





namespace Tyuiu.BurdovKS.Sprint2.Task5.V15.Lib
{
    public class DataService : ISprint2Task5V15
    {
        public string FindDayName(int k)
        {
            string res;


            int dayOfWeek = (k - 1) % 7 + 1;


            if ( k <= 0)
            {
                return "Некоректный номер дня";

            }

            switch (dayOfWeek)
            {
                case 1:
                    res = "Понедельник ";
                    break;

                case 2:
                    res = "Вторник ";
                    break;

                case 3:
                    res = "Среда ";
                    break;

                case 4:
                    res = "Четверг ";
                    break;

                case 5:
                    res = "Пятница ";
                    break;

                case 6:
                    res = "Суббота ";
                    break;

                case 7:
                    res = "Воскресенье ";
                    break;

                default:
                    res = "Неизвестный день ";
                    break;
                  
            }
            return res;
        }
    }
}
