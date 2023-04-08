/* Задача 35: Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */

/* Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */

int [] CreateArrayRndInt(int size, int min, int max)
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
/* void PrintArray(int[] arr)
{
    foreach (var element in arr)
        Console.Write($"{element} ");
} */

int QuantityExistElements(int[] arr)
{
    int i = 0;

    foreach (var element in arr)
    {
        if (element >= 10 && element <= 99)
            i++;
    }
    
    return i;
}

int[] array = CreateArrayRndInt(10, -100, 100);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Количество чисел лежащих в диапазоне от 10 до 99 равно {QuantityExistElements(array)}");