using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MusinND.Sprint6.Task4.V7.Lib
{
    public class DataService : ISprint6Task4V7
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            // Список для хранения результатов
            List<double> results = new List<double>();

            // Табулирование функции
            for (int x = startValue; x <= stopValue; x++)
            {
                double fx;

                try
                {
                    // Проверяем деление на ноль (x + 2 = 0)
                    if (x + 2 == 0)
                    {
                        fx = 0; // Возвращаем 0 при делении на ноль
                    }
                    else
                    {
                        // Вычисляем значение функции
                        fx = Math.Cos(x) + (Math.Cos(x) / (x + 2)) - (3 * x);
                    }
                }
                catch (DivideByZeroException)
                {
                    // В случае деления на ноль возвращаем 0
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
