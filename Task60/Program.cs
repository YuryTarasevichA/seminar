/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
двузначных чисел. Напишите программу, которая будет построчно 
выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

int[, ,] resultArray3d = CreateArrayMatrix3d(2, 2, 2, 10, 99);
Console.WriteLine("Исходная матрица:");
PrintMatrix3d(resultArray3d);

int[,,] CreateArrayMatrix3d(int rows, int colum, int depth, int min, int max)
{
    int[,,] arr = new int[rows, colum, depth];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] =  rnd.Next(10, 100);
            }
        }
    }
    return arr;
}
void PrintMatrix3d(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k], 3} ({i},{j},{k})");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}