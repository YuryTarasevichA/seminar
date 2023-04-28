/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.WriteLine("Введите целое положительное число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число N");
int n = Convert.ToInt32(Console.ReadLine());
int sum = SumNuturalNumbers(m, n);
if (m > 0 && n > 0)
    Console.WriteLine(sum);
else
    Console.WriteLine("Некорректный ввод!");

int SumNuturalNumbers(int firstM, int secondN)
{
    if (secondN > firstM)
    {
        return firstM + SumNuturalNumbers(firstM + 1, secondN);
    }
    else if (firstM > secondN)
    {
        return secondN + SumNuturalNumbers(secondN + 1, firstM);
    }
    else return secondN;
}




