using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KochetovAP.Sprint2.Task7.V15.Lib
{
    public class DataService : ISprint2Task7V15
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            return (x * x + y * y <= 4);
        }
    }
}
