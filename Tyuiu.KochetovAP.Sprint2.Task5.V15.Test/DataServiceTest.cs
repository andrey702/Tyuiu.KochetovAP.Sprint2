using Tyuiu.KochetovAP.Sprint2.Task5.V15.Lib;

namespace Tyuiu.KochetovAP.Sprint2.Task5.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValidEpression()
        {
            var service = new DataService();
            Assert.AreEqual("понедельник", service.FindDayName(1));
            Assert.AreEqual("воскресенье", service.FindDayName(7));
            Assert.AreEqual("вторник", service.FindDayName(365));
        }
    }
}
