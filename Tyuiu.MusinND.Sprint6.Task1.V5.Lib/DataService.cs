using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MusinND.Sprint6.Task1.V5.Lib
{
    public class DataService : ISprint6Task1V5
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            // Список для хранения значений f(x)
            List<double> results = new List<double>();

            for (int x = startValue; x <= stopValue; x++)
            {
                double fx;

                try
                {
                    // Вычисление значения функции
                    fx = Math.Sin(x) + (Math.Cos(2 * x) / 2) - 1.5 * x;

                    // Проверка деления на ноль
                    if (double.IsInfinity(fx) || double.IsNaN(fx))
                    {
                        fx = 0; // Возвращаем 0 при делении на 0
                    }
                }
                catch (DivideByZeroException)
                {
                    // Если произошло деление на ноль, возвращаем 0
                    fx = 0;
                }

                // Добавляем результат в список
                results.Add(fx);
            }

            // Возвращаем массив значений
            return results.ToArray();
        }
    }
}
