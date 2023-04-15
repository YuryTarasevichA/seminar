/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */

Console.WriteLine("Введите M число: ");
int size =  Convert.ToInt32(Console.ReadLine());

int[] CreateArrayRndInt(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите {i} элемент массива: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
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
int PositiveNumbers (int[] arr)
{
    int sumEl = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 0) sumEl++;
    }
    return sumEl;
}
Console.WriteLine("Заполните массив: ");
int[] array = CreateArrayRndInt(size);
Console.WriteLine("Полученный массив: ");
PrintArray(array);
Console.WriteLine();
int posSumElements = PositiveNumbers(array);
Console.WriteLine("Количество положительных чисел в массиве: ");
Console.WriteLine($"{posSumElements}");
