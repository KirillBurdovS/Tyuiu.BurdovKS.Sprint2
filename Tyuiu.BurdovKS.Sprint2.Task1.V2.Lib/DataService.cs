

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BurdovKS.Sprint2.Task1.V2.Lib
{
    public class DataService : ISprint2Task1V2
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {


            bool[] res = new bool[6];

            res[0] = (a + b) < (c + d) | (b + c) > (a + d);

            res[1] = (a + 100 > c) & (b + c > 100);

            res[2] = (d / 2) > (c / 2) || (a ^ b) == 0;

            res[3] = (b * 2) <= (d * 2) && !(c >= d);

            res[4] = !(a == b) ;

            res[5] = (a > 0) ^ (c > 0); ;


            return res;
        }
    }
}
