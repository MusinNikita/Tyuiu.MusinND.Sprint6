﻿using tyuiu.cources.programming.interfaces.Sprint6;

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

            // Копируем строки для сортировки
            var rowsArray = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                rowsArray[i] = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    rowsArray[i][j] = matrix[i, j];
                }
            }

            // Сортировка строк по 4-му столбцу с учётом стабильности
            Array.Sort(rowsArray, (row1, row2) => row1[3].CompareTo(row2[3]));

            // Преобразуем обратно в двумерный массив
            int[,] result = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = rowsArray[i][j];
                }
            }

            return result;
        }
    }
}
