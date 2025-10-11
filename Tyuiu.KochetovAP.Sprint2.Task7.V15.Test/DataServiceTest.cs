using Tyuiu.KochetovAP.Sprint2.Task7.V15.Lib;

namespace Tyuiu.KochetovAP.Sprint2.Task4.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 0;
            bool result = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            bool result = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea3()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            bool result = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(false, result);
        }
    }
}