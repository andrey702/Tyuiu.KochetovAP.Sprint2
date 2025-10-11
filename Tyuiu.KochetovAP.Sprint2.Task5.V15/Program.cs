using System;
using Tyuiu.KochetovAP.Sprint2.Task5.V15.Lib;

namespace Tyuiu.KochetovAP.Sprint2.Task6.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Кочетов А. П. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                             *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Кочетов А. П. | ИБКСб-25-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет       *");
            Console.WriteLine("* требуемое значение и возвращает результат.                              *");
            Console.WriteLine("* Определить, каким днем недели является k-й день не високосного года,   *");
            Console.WriteLine("* в котором 1 января понедельник.                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите номер дня года (1-365): ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string result = ds.FindDayName(k);
            Console.WriteLine($"{k}-й день года - {result}");

            Console.ReadKey();
        }
    }
}