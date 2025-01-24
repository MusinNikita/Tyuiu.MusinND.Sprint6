using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MusinND.Sprint6.Task0.V29.Lib
{
    public class DataService : ISprint6Task0V29
    {
        public double Calculate(int x)
        {
            double numerator = Math.Pow(x, 3) - 1;
            double denominator = 4 * Math.Pow(x, 2);

            double result = numerator / denominator;

            return Math.Round(result, 3);
        }
    }
}
