using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MusinND.Sprint6.Task3.V17.Lib
{
    public class DataService : ISprint6Task3V17
    {
        public int[,] Calculate(int[,] matrix)
        {
            // Получаем количество строк и столбцов
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (rows != 5 || cols != 5)
            {
                throw new ArgumentException("Массив должен быть размером 5x5.");
            }

            // Преобразуем двумерный массив в массив строк
            int[][] rowsArray = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                rowsArray[i] = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    rowsArray[i][j] = matrix[i, j];
                }
            }

            // Сортируем строки по значениям в четвёртом столбце (индекс 3)
            var sortedRows = rowsArray.OrderBy(row => row[3]).ToArray();

            // Преобразуем обратно в двумерный массив
            int[,] sortedMatrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sortedMatrix[i, j] = sortedRows[i][j];
                }
            }

            return sortedMatrix;
        }
    }
}
