using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MusinND.Sprint6.Task3.V17.Lib
{
    public class DataService : ISprint6Task3V17
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0); // Количество строк
            int cols = matrix.GetLength(1); // Количество столбцов

            // Проходим по каждой строке
            for (int i = 0; i < rows; i++)
            {
                // Создаем временный массив для строки
                int[] row = new int[cols];

                // Копируем элементы строки в массив
                for (int j = 0; j < cols; j++)
                {
                    row[j] = matrix[i, j];
                }

                // Сортируем временный массив строки
                Array.Sort(row);

                // Записываем отсортированную строку обратно в матрицу
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            // Возвращаем отсортированную матрицу
            return matrix;
        }
    }
}
