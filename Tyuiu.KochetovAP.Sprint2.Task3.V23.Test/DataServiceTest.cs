
using Tyuiu.KochetovAP.Sprint2.Task3.V23.Lib;

namespace Tyuiu.KochetovAP.Sprint2.Task3.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();
            double x = 5;
            double wait = 37.969;
            double res = ds.Calculate(x);
            res = System.Math.Round(res, 3);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x = 2;
            double wait = 18.000;
            double res = ds.Calculate(x);
            res = System.Math.Round(res, 3);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculate3()
        {
            DataService ds = new DataService();
            double x = 1;
            double wait = 4.000;
            double res = ds.Calculate(x);
            res = System.Math.Round(res, 3);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculate4()
        {
            DataService ds = new DataService();
            double x = 0;
            double wait = -16.000;
            double res = ds.Calculate(x);
            res = System.Math.Round(res, 3);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculate5()
        {
            DataService ds = new DataService();
            double x = -27;
            double wait = -297.001;
            double res = ds.Calculate(x);
            res = System.Math.Round(res, 3);
            Assert.AreEqual(wait, res);
        }
    }
}