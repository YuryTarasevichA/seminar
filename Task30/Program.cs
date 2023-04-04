/* Напишите программу, которая
выводит массив из 8 элементов, заполненный
нулями и еденицами в случайном порядке.
[1, 0, 1, 0, 0, 1, 0, 0] */

int [] ArreyBinary (int size)
{
    int [] array = new int[size];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 2);
    }
    return array;
}
void PrintArray(int[] array)
{
    foreach (var num in array)
    {
        Console.Write($"{num} ");
    }
}
PrintArray(ArreyBinary (10) ); 
