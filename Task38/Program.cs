/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и 
минимальным элементов массива.
[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2 */

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
} 

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}; ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}
double MaxElements (double[] arr)
{
    double max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (max <= arr[i])
        {
            max = arr[i];
        }
    }
    return max;
}
double MinElements (double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (min > arr[i])
        {
            min = arr[i];
        }
    }
    return min;
}

double[] array = CreateArrayRndDouble(7, 0, 100);
for (int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round(array[i], 1);
}
double maxElem = MaxElements(array);
double minElem = MinElements(array);
double differenceMaxMin = maxElem - minElem;
PrintArray(array);
Console.WriteLine();
Console.WriteLine(differenceMaxMin);
