using Tyuiu.KochetovAP.Sprint2.Task6.V6.Lib;

namespace Tyuiu.KochetovAP.Sprint2.Task6.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service = new DataService();
            int suit = 1;
            int rank = 12;
            string wait = "Дама пик";
            string result = service.FindCardNameAndValue(suit, rank);

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidFindCardNameAndValue2()
        {
            DataService service = new DataService();

            int suit = 3;
            int rank = 6;
            string wait = "Шестерка бубен";
            string result = service.FindCardNameAndValue(suit, rank);

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidFindCardNameAndValue3()
        {
            DataService service = new DataService();

            int suit = 4;
            int rank = 14;
            string wait = "Туз червей";
            string result = service.FindCardNameAndValue(suit, rank);

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidFindCardNameAndValue4()
        {
            DataService service = new DataService();

            int suit = 2;
            int rank = 11;
            string wait = "Валет треф";
            string result = service.FindCardNameAndValue(suit, rank);

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidSuitFindCardNameAndValue()
        {
            DataService service = new DataService();

            int suit = 5;
            int rank = 10;
            string result = service.FindCardNameAndValue(suit, rank);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidRankFindCardNameAndValue()
        {
            DataService service = new DataService();

            int suit = 2;
            int rank = 15;
            string result = service.FindCardNameAndValue(suit, rank);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidBothFindCardNameAndValue()
        {
            DataService service = new DataService();

            int suit = 0;
            int rank = 5;
            string result = service.FindCardNameAndValue(suit, rank);

        }
    }
}
