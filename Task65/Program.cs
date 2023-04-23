/* Задача 65: Задайте значения M и N. Напишите программу, которая
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8" */
Console.WriteLine("Введите целое положительное число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число N");
int n = Convert.ToInt32(Console.ReadLine());
if (m > 0 && n > 0)
    NuturalNumbers(m, n);
else
    Console.WriteLine("Некорректный ввод!");
void NuturalNumbers(int firstM, int secondN)
{
    if (firstM > secondN)
    {
        Console.Write($"{firstM}  ");
        NuturalNumbers(firstM - 1, secondN);
    }
    else if (firstM < secondN)
    {
        Console.Write($"{firstM}  ");
        NuturalNumbers(firstM + 1, secondN);
    }
    else { Console.WriteLine(firstM); }
}