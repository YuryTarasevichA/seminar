/* Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

Console.WriteLine ("Введите количество строк таблицы");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите количество столбцов таблицы");
int n = Convert.ToInt32(Console.ReadLine());

double [ , ] resultMatrix = CreateMatrixRndInt (m, n, 0, 10);
Console.WriteLine("Созданная матрица: ");
PrintMatrix(resultMatrix);
OrderArray(resultMatrix);
Console.WriteLine("изменённая матрица: ");
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
double[,] OrderArray(double[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        for (int i = 0; i < matrix.GetLength(1) - 1; i++)
        {
            for (int k = i + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[j, i] < matrix[j, k])
                {
                    double temp = matrix[j, i];
                    matrix[j, i] = matrix[j, k];
                    matrix[j, k] = temp;
                }
            }
        }
    }
    return matrix;
}

/* Данный метод OrderArray принимает двумерный массив matrix 
содержащий числовые значения. Метод сортирует элементы каждой строки массива по убыванию. 

Первый цикл for проходит по каждой строке массива matrix (переменная j индексирует строки). 

Второй цикл for проходит по каждому элементу строки (переменная i индексирует столбцы), 
кроме последнего, так как за последним элементом в строке не нужно 
совершать действий сравнения (при сортировке пузырьком пузырек всегда всплывает 
до конца, так как гарантированно поменьше элементов не было).

Третий цикл for проходит по оставшимся элементам строки, 
начиная со следующего за текущим (переменная k также индексирует столбцы). 

Если текущий элемент matrix[j, i] меньше элемента не следующего за ним, 
matrix[j, k], то метод меняет их местами, используя временную переменную temp
и операции присваивания. 

Наконец, метод возвращает отсортированный двумерный массив matrix, 
используя оператор return. */