/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

Console.WriteLine("Введите количество строк таблицы");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов таблицы");
int n = Convert.ToInt32(Console.ReadLine());

int[,] createMatrix = CreateMatrixRndInt(m, n, -100, 100);
PrintMatrix(createMatrix);
Console.WriteLine("Сумма элементов в столбцах: ");
double[] sumColumsAverage = CountTotalSummInColumsFast(createMatrix);
for (int i = 0; i < sumColumsAverage.Length; i++)
{
    Console.WriteLine($"Столбец {i + 1}: {sumColumsAverage[i]}");
}

int [ , ] CreateMatrixRndInt(int rows, int colums, int min, int max)
{
    int[ , ] matrix = new int[rows, colums];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)// for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)//for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix (int[ , ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
       Console.Write("|");
       for (int j = 0; j < matrix.GetLength(1); j++)
       {
            Console.Write($"{matrix[i, j], 6}");
       }
       Console.WriteLine(" |");
       Console.WriteLine();
    }
}
double [] CountTotalSummInColumsFast(int[,] matrix)
{
    int size = matrix.GetLength(1);
    double[] sumCol = new double [size];
    double average = 0;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int totalSumm = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            totalSumm += matrix[i, j];
        }
        average = (double)totalSumm/matrix.GetLength(0);
        sumCol[j] = Math.Round(average, 2, MidpointRounding.ToZero);
    }
    return sumCol;
}
