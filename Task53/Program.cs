/* Задача 53: Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива. */

Console.WriteLine ("Введите количество строк таблицы");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите количество столбцов таблицы");
int n = Convert.ToInt32(Console.ReadLine());

double [ , ] resultMatrix = CreateMatrixRndInt (m, n, -10, 10);
Console.WriteLine("Созданная матрица: ");
PrintMatrix(resultMatrix);
EditMatrix(resultMatrix);
Console.WriteLine("После замены первой и последней строки матрицы: ");
PrintMatrix(resultMatrix);

double [ , ] CreateMatrixRndInt(int rows, int columns, double min, double max)
{
    double[ , ] matrix = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)// for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)//for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.NextDouble() * (max - min) + min;
            matrix[i, j] = Math.Round(matrix[i , j], 2);
        }
    }
    return matrix;
}
void PrintMatrix (double[ , ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
       Console.Write("|");
       for (int j = 0; j < matrix.GetLength(1); j++)
       {
            Console.Write($"{matrix[i, j], 10}");
       }
       Console.WriteLine(" |");
       Console.WriteLine();
    }
}
void EditMatrix (double [,] matrix)
{
    int firstRow = 0;
    int lastRow = matrix.GetLength(0)-1;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double temp = matrix [firstRow, i];
        matrix[firstRow, i] = matrix[lastRow, i];
        matrix[lastRow, i] = temp;
    }
}


