/* Задача 44. Не использя рекурсию, выведите первые N чисел
Фибоначчи. Первые два числа фибоначчи: 0 и 1. */

Console.WriteLine("Введите число N:");
int num =  Convert.ToInt32(Console.ReadLine());
int [] FibonacciNumbers (int num)
{
    int[] fiboArray = new int[num];
    fiboArray[0] = 0;
    fiboArray[1] = 1;
    for (int i = 2; i < num; i++)
    {
        fiboArray[i] = fiboArray[i-1] + fiboArray[i-2];
    }
    return fiboArray;
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

PrintArray(FibonacciNumbers(num));

