

using Tyuiu.BurdovKS.Sprint2.Task3.V22.Lib;


namespace Tyuiu.BurdovKS.Sprint2.Task3.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculation1()
        {
            DataService ds = new DataService();

            double x = 2;

            double res = ds.Calculate(x);

            double wait = 27;

            Assert.AreEqual(wait,res);

        }


        [TestMethod]
        public void ValidCalculation2()
        {
            DataService ds = new DataService();

            double x = 0;

            double res = ds.Calculate(x);

            double wait = 0.75;

            Assert.AreEqual(wait, res);
        }


        [TestMethod]
        public void ValidCalculation3()
        {

            DataService ds = new DataService();

            double x = 1;

            double res = ds.Calculate(x);

            double wait = 5;

            Assert.AreEqual(wait, res);

        }


        [TestMethod]
        public void ValidCalculation4()
        {

            DataService ds = new DataService();

            double x = -50;

            double res = ds.Calculate(x);

            double wait = -549.98;

            Assert.AreEqual(wait, res);

        
    }


    }
}