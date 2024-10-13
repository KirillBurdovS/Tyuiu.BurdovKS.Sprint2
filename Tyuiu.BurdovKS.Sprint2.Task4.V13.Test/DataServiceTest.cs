

using Tyuiu.BurdovKS.Sprint2.Task4.V13.Lib;






namespace Tyuiu.BurdovKS.Sprint2.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();

            double x = 4;

            double y = 13;

            double res = ds.Calculate(x, y);

            double wait = 15.828;

            Assert.AreEqual(wait, res);




        }



        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();

            double x = 4;

            double y = 30;

            double res = ds.Calculate(x, y);

            double wait = 15.024;

            Assert.AreEqual(wait, res);
            



        }

    }
}