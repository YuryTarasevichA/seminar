/* Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

Console.WriteLine ("Введите количество строк первой матрицы");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите количество столбцов первой матрицы");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите количество строк второй матрицы");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите количество столбцов второй матрицы");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите минимальное значение матрицы");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите максимальное значение матрицы");
int maximum = Convert.ToInt32(Console.ReadLine());

double[,] resultMatrix = CreateMatrixRndInt(m, n, minimum, maximum);
Console.WriteLine("Созданная матрица: ");
PrintMatrix(resultMatrix);

double[,] result2Matrix = CreateMatrixRndInt(a, b, minimum, maximum);
Console.WriteLine("Созданная вторая матрица: ");
PrintMatrix(result2Matrix);
if (resultMatrix.GetLength(1) == result2Matrix.GetLength(0) || result2Matrix.GetLength(1) == resultMatrix.GetLength(0))
{ 
    double[,] multiplyMatrices = MultiplyMatrices(resultMatrix, result2Matrix);
    for (int i = 0; i < multiplyMatrices.GetLength(0); i++)
    {
        for (int j = 0; j < multiplyMatrices.GetLength(1); j++)
        {
            multiplyMatrices[i, j] = Math.Round(multiplyMatrices[i, j], 2);
        }
    }
    Console.WriteLine("Результат перемножения двух матриц: ");
    PrintMatrix(multiplyMatrices);
}
else
{
    Console.WriteLine("Некорретный ввод матриц, невозможно перемножить матрицы данного размера");
} 


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
double[,] MultiplyMatrices(double[,] matrix1, double[,] matrix2)
{
    int rows1 = matrix1.GetLength(0);
    int cols1 = matrix1.GetLength(1);
    int rows2 = matrix2.GetLength(0);
    int cols2 = matrix2.GetLength(1);
    double[,] result = new double[rows1, cols2];

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < cols2; j++)
        {
            for (int k = 0; k < cols1; k++)
            {
               result[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }

    return  result;
}