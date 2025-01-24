using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MusinND.Sprint6.Task5.V3.Lib
{
    public class DataService : ISprint6Task5V3
    {
        public double[] LoadFromDataFile(string path)
        {
            // Список для хранения вещественных чисел
            List<double> realNumbers = new List<double>();

            try
            {
                // Чтение строк из файла
                string[] lines = File.ReadAllLines(path);

                // Перебираем строки из файла
                foreach (string line in lines)
                {
                    // Пробуем преобразовать строку в число
                    if (double.TryParse(line.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
                    {
                        // Проверяем, является ли число вещественным
                        if (number % 1 != 0)
                        {
                            // Округляем до трех знаков после запятой и добавляем в список
                            realNumbers.Add(Math.Round(number, 3));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Обработка ошибок чтения файла
                Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
                throw;
            }

            // Возвращаем массив вещественных чисел
            return realNumbers.ToArray();
        }
    }
}
