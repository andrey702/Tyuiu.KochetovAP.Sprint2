using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KochetovAP.Sprint2.Task5.V15.Lib
{
    public class DataService : ISprint2Task5V15
    {
        public string FindDayName(int k)
        {
            if (k < 1 || k > 365)
                throw new ArgumentOutOfRangeException(nameof(k), "Число должно быть от 1 до 365.");


            int dayOfWeek = (k + 6) % 7;

            switch (dayOfWeek)
            {
                case 0: return "понедельник";
                case 1: return "вторник";
                case 2: return "среда";
                case 3: return "четверг";
                case 4: return "пятница";
                case 5: return "суббота";
                case 6: return "воскресенье";
                default: return "неизвестно";
            }
        }
    }
}