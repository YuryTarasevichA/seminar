/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 1, 33, 6] */
int [] ArreyBinary (int size)
{
    int [] array = new int[size];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 1000000);
    }
    return array;
}
void PrintArray(int[] array)
{
    foreach (var num in array)
    {
        Console.Write($"[{num}] ");
    }
}
PrintArray(ArreyBinary (8)); 