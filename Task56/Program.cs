/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт
номер строки с наименьшей суммой элементов: 1 строка */

Console.WriteLine ("Введите количество строк таблицы");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите количество столбцов таблицы");
int n = Convert.ToInt32(Console.ReadLine());
double[,] resultMatrix = CreateMatrixRndInt(m, n, 0, 10);
Console.WriteLine("Созданная матрица: ");
PrintMatrix(resultMatrix);
double[] sumArray = SumArray(resultMatrix);
for (int i = 0; i < sumArray.Length; i++)
{
    sumArray[i] = Math.Round(sumArray[i], 2);
}
Console.WriteLine("Выводим массив из сумм строк: ");
PrintArray(sumArray);
double sumArrayMin = SumArrayMin(sumArray);
Console.WriteLine();
Console.WriteLine($"Выводим строку с наименьшей суммой элементов: {sumArrayMin}");

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
double[] SumArray(double[,] matrix)
{ 
    int size = matrix.GetLength(0); 
    double[] arr = new double[size]; 
    
    for (int i = 0; i < size; i++)
    { 
        double sum = 0; 
        for (int j = 0; j < matrix.GetLength(1); j++) 
        { 
            sum += matrix[i, j];  
        } 
        arr[i] = sum;  
    }
    return arr;  
}
double SumArrayMin (double[] arr)
{
    int lineNumber = 0;
    int minIndex = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < arr[minIndex])
        {
            minIndex = i;
            lineNumber = minIndex +1;
        }
    }
    return lineNumber;
}
void PrintArray (double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
       if (i < arr.Length - 1) Console.Write($"{arr[i]}; ");
       else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

