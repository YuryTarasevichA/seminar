/* Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это невозможно,
программа должна вывести сообщение для пользователя. */


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
void EditMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            double temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }

    }
}
bool CheckMatrix(double [ , ] matrix)
{
    return matrix.GetLength(0) == matrix.GetLength(1);
}

Console.WriteLine ("Введите количество строк таблицы");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите количество столбцов таблицы");
int n = Convert.ToInt32(Console.ReadLine());

double [ , ] resultMatrix = CreateMatrixRndInt (m, n, -10, 10);
Console.WriteLine("Созданная матрица: ");
PrintMatrix(resultMatrix);
if (CheckMatrix(resultMatrix))
{
    EditMatrix(resultMatrix);
    Console.WriteLine("После замены строк на столбцы матрицы: ");
    PrintMatrix(resultMatrix);
}
else {Console.WriteLine("Матрица не является квадратной" );}