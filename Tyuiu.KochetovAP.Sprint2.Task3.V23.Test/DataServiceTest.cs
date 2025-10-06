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
            Assert.AreEqual(Math.Round(service.Calculate(5), 3), 37.969);
            Assert.AreEqual(Math.Round(service.Calculate(2), 3), 18.000);
            Assert.AreEqual(Math.Round(service.Calculate(1), 3), 4.000);
            Assert.AreEqual(Math.Round(service.Calculate(0), 3), -16.000);
            Assert.AreEqual(Math.Round(service.Calculate(-27), 3), -297.001);

        }
    }
}
