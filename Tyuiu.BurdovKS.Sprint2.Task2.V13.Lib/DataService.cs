

using System.Security.Cryptography.X509Certificates;
using tyuiu.cources.programming.interfaces.Sprint2;




namespace Tyuiu.BurdovKS.Sprint2.Task2.V13.Lib
{
    public class DataService : ISprint2Task2V13
    {
        public bool CheckDotInShadedArea(int x, int y)
        {

            bool res;

            
 






            if ((x >= 4) && (y > 2) && (y <= 8)) return true;
            if ((x >= 3) && (x <= 7) && (y >= 6) && (y < 7)) return true;
            if ((x >= 3) && (x <= 5) && (y >= 11) && (y < 12)) return true;
            if ((x >= 9) && (x <= 12) && (((y >= 3) && (y < 4)) || (y >= 10) && (y < 11))) return true;
            if ((x >= 13) && (x < 14) && (y >= 6) && (y <= 8)) return true;
            if ((x >= 8) && (x < 9) && (y >= 5) && (y <= 12)) return true;
            if ((x >= 9) && (x < 10) && (y >= 11) && (y <= 12)) return true;
            if ((x >= 7) && (x < 8) && (y > 12)) return true;
            if ((x >= 6) && (x <= 7) && (y >= 10) && (y <= 11)) return true;


            else return false;



















            return res;





        }
    }
}
