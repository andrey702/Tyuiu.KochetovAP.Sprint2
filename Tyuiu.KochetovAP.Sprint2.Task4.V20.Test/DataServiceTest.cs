using System;
using Tyuiu.KochetovAP.Sprint2.Task4.V20.Lib;

namespace Tyuiu.KochetovAP.Sprint1.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double res = Math.Round( ds.Calculate(5, 2), 3);
            double wait = 1.187;

            Assert.AreEqual(wait, res);
        }
    }
}