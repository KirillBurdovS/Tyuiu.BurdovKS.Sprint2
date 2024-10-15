



using tyuiu.cources.programming.interfaces.Sprint2;




namespace Tyuiu.BurdovKS.Sprint2.Task7.V7.Lib
{
    public class DataService : ISprint2Task7V7
    {
        public bool CheckDotInShadedArea(double x, double y)
        {

            bool res;

            double xx = Math.Pow(x, 2);

            double xcore = Math.Sqrt(x);

            if ((y<= (2 - xx) && ( y >= x) && (x <= 0)))
            {
                res = true;
            }
            if ((y <= (2 - xx) && (y >= x) && (x <= xcore))) 
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;




        }
    }
}
