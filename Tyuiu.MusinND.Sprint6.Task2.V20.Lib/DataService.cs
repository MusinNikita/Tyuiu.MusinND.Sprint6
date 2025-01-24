using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MusinND.Sprint6.Task2.V20.Lib
{
    public class DataService : ISprint6Task2V20
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            // Список для хранения значений функции
            List<double> results = new List<double>();

            for (int x = startValue; x <= stopValue; x++)
            {
                double fx;

                try
                {
                    // Проверяем деление на ноль (x + 1.2 = 0)
                    if (x + 1.2 == 0)
                    {
                        fx = 0; // Если деление на ноль, возвращаем 0
                    }
                    else
                    {
                        // Вычисляем значение функции
                        fx = (Math.Sin(x) / (x + 1.2)) - (2 * Math.Sin(x)) - (2 * x);
                    }
                }
                catch (DivideByZeroException)
                {
                    // Если возникает деление на ноль, возвращаем 0
                    fx = 0;
                }

                // Округляем результат до двух знаков после запятой
                fx = Math.Round(fx, 2);

                // Добавляем результат в список
                results.Add(fx);
            }

            // Преобразуем список в массив и возвращаем
            return results.ToArray();
        }
    }
}
