using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KochetovAP.Sprint2.Task6.V6.Lib
{
    public class DataService : ISprint2Task6V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            if (value1 < 1 || value1 > 4)
                throw new ArgumentException("Номер масти должен быть в диапазоне от 1 до 4");

            if (value2 < 6 || value2 > 14)
                throw new ArgumentException("Номер достоинства должен быть в диапазоне от 6 до 14");
            string suitName = value1 switch
            {
                1 => "пик",
                2 => "треф",
                3 => "бубен",
                4 => "червей",
                _ => throw new ArgumentException("Некорректный номер масти")
            };
            string rankName = value2 switch
            {
                6 => "шестерка",
                7 => "семерка",
                8 => "восьмерка",
                9 => "девятка",
                10 => "десятка",
                11 => "валет",
                12 => "дама",
                13 => "король",
                14 => "туз",
                _ => throw new ArgumentException("Некорректный номер достоинства")
            };
            return $"{rankName} {suitName}";

        }
    }
}
