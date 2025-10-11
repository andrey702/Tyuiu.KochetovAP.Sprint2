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
                6 => "Шестерка",
                7 => "Семерка",
                8 => "Восьмерка",
                9 => "Девятка",
                10 => "Десятка",
                11 => "Валет",
                12 => "Дама",
                13 => "Король",
                14 => "Туз",
                _ => throw new ArgumentException("Некорректный номер достоинства")
            };
            return $"{rankName} {suitName}";

        }
    }
}
