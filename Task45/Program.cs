﻿/* Задача 45. Напишите программу, которая будет создавть 
копию заданного массива с помощью поэлементного копирования */

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}
void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
       if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
       else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int[] CopyArray (int[] array)
{
    int [] resultArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        resultArray[i] = array[i];
    }
    return resultArray;
} 
int[] array = CreateArrayRndInt(12, -9, 9);
Console.WriteLine("Исходный массив:");
PrintArray(array);
Console.WriteLine();
int [] newCopyArray = CopyArray(array);
Console.WriteLine("Копия:");
PrintArray(newCopyArray);