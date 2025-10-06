using System;
using Tyuiu.KochetovAP.Sprint2.Task4.V20.Lib;

namespace Tyuiu.KochetovAP.Sprint2.Task4.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Кочетов А. П. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Тернарный оператор                                                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Кочетов А. П. | ИБКСб-25-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет значение с использованием        *");
            Console.WriteLine("* тернарного оператора. Ответ округлить до 3 знаков после запятой.       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            double res = ds.Calculate(x, y);
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}