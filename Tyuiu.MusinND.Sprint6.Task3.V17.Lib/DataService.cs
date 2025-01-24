using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MusinND.Sprint6.Task3.V17.Lib
{
    public class DataService : ISprint6Task3V17
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Проверка на размер 5x5
            if (rows != 5 || cols != 5)
                throw new ArgumentException("Массив должен быть размером 5x5.");

            // Создаём список строк, чтобы сохранить стабильность сортировки
            var indexedRows = new (int Index, int[] Row)[rows];
            for (int i = 0; i < rows; i++)
            {
                indexedRows[i] = (i, new int[cols]);
                for (int j = 0; j < cols; j++)
                {
                    indexedRows[i].Row[j] = matrix[i, j];
                }
            }

            // Сортируем по 4-му столбцу с учётом стабильности
            Array.Sort(indexedRows, (x, y) => x.Row[3].CompareTo(y.Row[3]));

            // Преобразуем обратно в двумерный массив
            int[,] result = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = indexedRows[i].Row[j];
                }
            }

            return result;
        }
    }
}
