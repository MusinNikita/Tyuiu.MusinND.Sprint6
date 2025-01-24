using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MusinND.Sprint6.Task3.V17.Lib
{
    public class DataService : ISprint6Task3V17
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Проверка размера массива
            if (rows != 5 || cols != 5)
                throw new ArgumentException("Массив должен быть размером 5x5.");

            // Преобразуем двумерный массив в массив строк для сортировки
            var sortedRows = Enumerable.Range(0, rows)
                .Select(i => Enumerable.Range(0, cols).Select(j => matrix[i, j]).ToArray())
                .OrderBy(row => row[3]) // Сортируем по четвёртому столбцу
                .ToArray();

            // Возвращаем отсортированный массив
            int[,] result = new int[rows, cols];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    result[i, j] = sortedRows[i][j];

            return result;
        }
    }
}
