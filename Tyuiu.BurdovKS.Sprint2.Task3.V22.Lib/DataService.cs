

using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.BurdovKS.Sprint2.Task3.V22.Lib
{
    public class DataService : ISprint2Task3V22
    {
        public double Calculate(double x)
        {
            double y = 0;

            double z = 0;

            double zy = 0;

            double zyz = 0;


            if (x > 1)
            {
                y = x + Math.Pow((x + 3), x) / Math.Pow((x - 1), x);
            }
            else
            {
                if ( x == 0)
                {
                    z = Math.Pow(x, 2) - Math.Cos(x) + 10;
                    
                    zy = Math.Pow(x, 2) - Math.Sin(x) + 12;

                    y = z / zy;
                }
                else
                {
                    if ((x > -26) && ( x < 2))
                    {

                        z = Math.Pow(x, 2);

                        zy = 2 / z;

                        zyz = 3 + zy;

                        y = Math.Pow(zyz, x);
                    }
                    else
                    {

                        if(x < -26)
                        {
                            z = 10 * x;

                            zy = 1 / x;

                            zyz = x + z;

                            y = zyz - zy;
                        }
                        

                    }
                }
            }



            return Math.Round(y, 3);
        }
    }
}
