using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MusinND.Sprint6.Task3.V17.Lib
{
    public class DataService : ISprint6Task3V17
    {
        public int[,] Calculate(int[,] matrix)
        {
            // Проверяем, что матрица имеет правильный размер 5x5
            if (matrix.GetLength(0) != 5 || matrix.GetLength(1) != 5)
            {
                throw new ArgumentException("Матрица должна быть размером 5x5.");
            }

            // Массив для хранения значений 3-го столбца
            int[] column3 = new int[5];

            // Извлекаем 3-й столбец
            for (int i = 0; i < 5; i++)
            {
                column3[i] = matrix[i, 3];
            }

            // Сортируем 3-й столбец по возрастанию
            Array.Sort(column3);

            // Вставляем отсортированные значения обратно в 3-й столбец
            for (int i = 0; i < 5; i++)
            {
                matrix[i, 3] = column3[i];
            }

            // Возвращаем отсортированную матрицу
            return matrix;
        }
    }
}
