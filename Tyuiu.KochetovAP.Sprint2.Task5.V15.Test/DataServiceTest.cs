using Tyuiu.KochetovAP.Sprint2.Task5.V15.Lib;
namespace Tyuiu.KochetovAP.Sprint2.Task6.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();
            string result = ds.FindDayName(1);
            Assert.AreEqual("Понедельник", result);
        }

        [TestMethod]
        public void ValidFindDayName2()
        {
            DataService ds = new DataService();
            string result = ds.FindDayName(7);
            Assert.AreEqual("Воскресенье", result);
        }

        [TestMethod]
        public void ValidFindDayName3()
        {
            DataService ds = new DataService();
            string result = ds.FindDayName(365);
            Assert.AreEqual("Понедельник", result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidFindDayName()
        {
            DataService ds = new DataService();
            ds.FindDayName(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidFindDayName2()
        {
            DataService ds = new DataService();
            ds.FindDayName(366);
        }
    }
}