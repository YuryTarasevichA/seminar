﻿/* Задача 57: Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных. */

Console.WriteLine("Введите количество строк таблицы");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов таблицы");
int n = Convert.ToInt32(Console.ReadLine());

int[,] resultArray = CreateArrayMatrix(m, n, 1, 10);
Console.WriteLine("Исходная матрица:");
PrintArray(resultArray);
int[] finalArray = ConvertMatrixToArray(resultArray);
Console.WriteLine("Выводим одномерный массив:");
PrintArray2d(finalArray);
Array.Sort(finalArray);
Console.WriteLine("Выводим одномерный упорядоченный массив:");
PrintArray2d(finalArray);

Console.WriteLine("Выводим частотный словарь:");
CountAndPrintFrequencies(finalArray);


void CountAndPrintFrequencies (int[] array)
{
    int previousElement = array[0];
    int counter = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == previousElement) counter++;
        else
        {
            Console.WriteLine($"Число {previousElement } встречается {counter} раз ");
            counter=1;
            previousElement=array[i];
        }
    }
}
int[] ConvertMatrixToArray (int[,] array)
{
    int[] resultArray = new int[array.GetLength(0)*array.GetLength(1)];
    int countIndex =0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            resultArray[countIndex] = array[i,j];
            countIndex++; 
        }
    }
    return resultArray;
}

void PrintArray2d (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
       if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
       else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int[,] CreateArrayMatrix(int rows, int colum, int min, int max)
{
    int[,] arr = new int[rows, colum];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i < arr.Length - 1) Console.Write($"{arr[i, j],3} ");
            else Console.Write($"{arr[i, j]}");
        }
        Console.WriteLine();
    }
}

/* Этот код предлагает пользователю ввести количество строк и столбцов для матрицы,
создает матрицу, заполненную случайными целыми числами от 1 до 10, 
преобразует матрицу в одномерный массив, сортирует массив в порядке возрастания, 
а затем распечатывает частота каждого целого числа в массиве.

Метод CountAndPrintFrequencies перебирает отсортированный массив и подсчитывает, 
сколько раз подряд появляется каждое целое число. Когда он встречает
новое целое число, он выводит частоту предыдущего целого числа и сбрасывает
счетчик для нового целого числа.

Метод ConvertMatrixToArray перебирает матрицу и копирует каждый элемент
в одномерный массив.

Метод PrintArray2d просто выводит
одномерный массив с квадратными скобками и запятыми,
разделяющими каждый элемент.

Метод CreateArrayMatrix создает матрицу со случайными
целыми числами между указанными минимальным и максимальным значениями.

Метод PrintArray просто распечатывает двумерный массив,
каждый элемент которого разделен пробелами. */