using Tyuiu.KochetovAP.Sprint2.Task3.V23.Lib;

namespace Tyuiu.KochetovAP.Sprint2.Task3.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service = new DataService();
            Assert.AreEqual(Math.Round(2 * Math.Pow(3, 2), 3), Math.Round(service.Calculate(2), 3));
            Assert.AreEqual(Math.Round((double)-16, 3), Math.Round(service.Calculate(0), 3));

        }
    }
}
