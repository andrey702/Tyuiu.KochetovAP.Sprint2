using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KochetovAP.Sprint2.Task3.V23.Lib
{
    public class DataService : ISprint2Task3V23
    {
        public double Calculate(double x)
        {
            if (x > 1) return x * Math.Pow((x + 1) / (x - 1), x);
            if (x == 0) return Math.Pow(x, 2) + Math.Cos(Math.Pow(x, 2)) - 17;
            if (x > -27 && x <= 1) return Math.Pow(3 + 1 / Math.Pow(x, 2), x);
            if (x <= -27) return 11 * x - 1 / Math.Pow(x, 2);
            throw new ArgumentException("неверное значение x");

        }
    }
}
