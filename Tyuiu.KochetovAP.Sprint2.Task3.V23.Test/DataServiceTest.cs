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
            Assert.AreEqual(2 * Math.Pow(3, 2), service.Calculate(2), 0.001);
            Assert.AreEqual(-16, service.Calculate(0), 0.001);

        }
    }
}
