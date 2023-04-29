/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int[,] resultArray = CreateArrayMatrix(4, 4, 0, 100);
Console.WriteLine("Исходная матрица:");
PrintMatrix(resultArray);

int[,] CreateArrayMatrix(int rows, int colum, int min, int max)
{
    int[,] array = new int[4, 4];
    int value = 1;
    int rowStart = 0;
    int rowEnd = array.GetLength(0) - 1;
    int colStart = 0;
    int colEnd = array.GetLength(1) - 1;

    while (rowStart <= rowEnd && colStart <= colEnd)
    {
        // Заполнить верхнюю строку слева направо
        for (int i = colStart; i <= colEnd; i++)
        {
            array[rowStart, i] = value++;
        }
        rowStart++;

        // Заполнить правую колонку сверху вниз
        for (int i = rowStart; i <= rowEnd; i++)
        {
            array[i, colEnd] = value++;
        }
        colEnd--;

        if (rowStart <= rowEnd)
        {
            // Заполнить нижний ряд справа налево
            for (int i = colEnd; i >= colStart; i--)
            {
                array[rowEnd, i] = value++;
            }
            rowEnd--;
        }

        if (colStart <= colEnd)
        {
            // Заполнить левую колонку снизу вверх
            for (int i = rowEnd; i >= rowStart; i--)
            {
                array[i, colStart] = value++;
            }
            colStart++;
        }
    }
    return array;
}
void PrintMatrix(int[,] array)
{
    // Распечатать полученный спиральный массив
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0:D2} ", array[i, j]);
        }
        Console.WriteLine();
    }
}

